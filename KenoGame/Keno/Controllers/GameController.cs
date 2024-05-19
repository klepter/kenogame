using KenoGame.Controls;
using KenoGame.Keno.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KenoGame.Keno.Controllers
{
    public class GameController
    {
        private readonly Game game = new Game();
        private readonly SelectedSpots selectedSpots = new SelectedSpots();

        public void InitiateGame(InitialControls initialControls)
        {
            initialControls.PlayerBankLabel.Text = game.Player.Bank.ToString();
            initialControls.BetNumeric.Value = (decimal)game.Bet;
            initialControls.AttemptNumeric.Value = game.AttemptsCount;
        }

        public void SpotToggle(Button spot)
        {
            bool isAdded;
            try
            {
                isAdded = selectedSpots.Add(int.Parse(spot.Text), game.Player.Bank, game.Bet, game.AttemptsCount);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                isAdded = false;
            }
            if (isAdded)
            {
                ButtonDraw.DrawOutline(spot);
            }
            else
            {
                ButtonDraw.EraseOutline(spot);
            }
        }

        public void SetBetNumericValue(NumericUpDown betNumeric)
        {
            game.Bet = (double)betNumeric.Value;
            betNumeric.Value = (decimal)game.Bet;
        }

        public void SetAttemptNumericValue(NumericUpDown attemptsNumeric)
        {
            game.AttemptsCount = (int)attemptsNumeric.Value;
            attemptsNumeric.Value = game.AttemptsCount;
        }

        public void ClearSpots(FlowLayoutPanel flowLayoutPanel)
        {
            selectedSpots.Clear();
            foreach (var spot in flowLayoutPanel.Controls.OfType<Button>())
            {
                ButtonDraw.EraseOutline(spot);
            }
        }

        public async void Start(InitialControls initialControls, FlowLayoutPanel flowLayoutPanel, Label winningLabel)
        {
            if (selectedSpots.Count == 0)
            {
                MessageBox.Show("Выберите хотя бы один спот!");
                return;
            }
            ToggleInitialControls(initialControls, flowLayoutPanel);
            winningLabel.Text = "";
            for (int i = 0; i < game.AttemptsCount; i++)
            {
                game.Player.DecreaseBank(game.Bet * selectedSpots.Count);
                initialControls.PlayerBankLabel.Text = game.Player.Bank.ToString();
                var attempt = new Attempt();
                var winningSpots = attempt.GenerateWinningSpots();
                await PaintWinningSpots(winningSpots, flowLayoutPanel);
                var winning = attempt.CalculateWinning(selectedSpots.GetSpots(), winningSpots, game.Bet);
                winningLabel.Text += $"Попытка {i+1}\nВыигрыш\n{winning}\n\n";
                if (winning > 0)
                {
                    game.Player.IncreaseBank(winning);
                    initialControls.PlayerBankLabel.Text = game.Player.Bank.ToString();
                }
                await Task.Delay(1000);
                await PaintWinningSpots(winningSpots, flowLayoutPanel, true);
            }
            ToggleInitialControls(initialControls, flowLayoutPanel, true);
        }

        private async Task PaintWinningSpots(List<int> winningSpots, FlowLayoutPanel flowLayoutPanel, bool isErase = false)
        {
            foreach (var spot in winningSpots)
            {
                var winningSpot = flowLayoutPanel.Controls.Find($"spot{spot}", false).First();
                if (winningSpot is Button winSpotBtn)
                {
                    if (isErase)
                    {
                        ButtonDraw.EraseCircle(winSpotBtn);
                    }
                    else
                    {
                        ButtonDraw.DrawCircle(winSpotBtn);
                        await Task.Delay(500);
                    }
                }
            }
        }

        private void ToggleInitialControls(InitialControls initialControls, FlowLayoutPanel flowLayoutPanel, bool turnOff = false)
        {
            initialControls.AttemptNumeric.Enabled = turnOff;
            initialControls.BetNumeric.Enabled = turnOff;
            flowLayoutPanel.Enabled = turnOff;
        }
    }
}
