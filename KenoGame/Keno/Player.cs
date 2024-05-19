namespace KenoGame.Keno
{
    public class Player
    {
        public double Bank { get; private set; }

        public Player(double bank = 1000)
        {
            Bank = bank;
        }

        public double IncreaseBank(double amount)
        {
            Bank += amount;
            return Bank;
        }

        public double DecreaseBank(double amount)
        {
            Bank = amount > Bank ? 0 : Bank - amount;
            return Bank;
        }
    }
}
