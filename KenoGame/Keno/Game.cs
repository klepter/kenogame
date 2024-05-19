using System;


namespace KenoGame.Keno
{
    public class Game
    {
        private const double maxBet = 50;
        private const int maxAttempts = 10;
        private int attempts = 1;
        private double bet = 0.5;

        public Player Player { get; } = new Player(bank:100);

        public double Bet
        {
            get => bet;
            set
            {
                if (value <= maxBet)
                {
                    bet = Player.Bank >= value ? value : Player.Bank;
                }
                else
                {
                    bet = Player.Bank <= maxBet ? Player.Bank : maxBet;
                }
            }
        }

        public int AttemptsCount
        {
            get => attempts;
            set
            {
                int maxAvailableAttemptForPlayer = (int)Math.Floor(Player.Bank / bet);
                attempts = value;
                if (value > maxAttempts)
                {
                    attempts = maxAttempts;
                }
                else if (value > maxAvailableAttemptForPlayer)
                {
                    attempts = maxAvailableAttemptForPlayer;
                }
            }
        }
    }
}
