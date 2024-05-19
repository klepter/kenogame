using KenoGame.Keno;
using KenoGame.Keno.Controllers;
using KenoGame.Keno.Schemas;
using System;
using System.Windows.Forms;


namespace KenoGame
{
    public partial class MainForm : Form
    {
        private readonly Game game = new Game();
        private readonly GameController controller = new GameController();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controller.InitiateGame(new InitialControls(
                    playerBank, betNumeric, attemptNumeric
                ));
        }

        private void Spot_Click(object sender, EventArgs e)
        {
            if (sender is Button spot)
            {
                controller.SpotToggle(spot);
            }
            else
            {
                Console.WriteLine($"{sender.GetType()} is invalid type of sender.");
            }
        }

        private void SetBet_ValueChange(object sender, EventArgs e)
        {
            if (sender is NumericUpDown betNumeric)
            {
                controller.SetBetNumericValue(betNumeric);
            }
            else
            {
                Console.WriteLine($"{sender.GetType()} is invalid type of sender.");
            }
        }

        private void SetAttemptsCount_ValueChange(object sender, EventArgs e)
        {
            if (sender is NumericUpDown attemptsNumeric)
            {
                controller.SetAttemptNumericValue(attemptsNumeric);
            }
            else
            {
                Console.WriteLine($"{sender.GetType()} is invalid type of sender.");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            controller.ClearSpots(flowLayoutPanel);
        }

        private void gameStartBtn_Click(object sender, EventArgs e)
        {
            controller.Start(new InitialControls(
                    playerBank, betNumeric, attemptNumeric
                ), flowLayoutPanel, winningLabel);
        }
    }
}
