using System;
using System.Collections.Generic;


namespace KenoGame.Keno
{
    internal class SelectedSpots
    {
        private readonly List<int> spots = new List<int>();

        public int Count
        {
            get => spots.Count;
        }

        public bool Add(int val, double bank, double bet, int attempts)
        {
            if (IsValidSpot(val) == false)
            {
                throw new ArgumentException("Неверное значение");
            }
            else if (spots.Contains(val))
            {
                spots.Remove(val);
                return false;
            }
            else if (bank < bet * (Count + 1) * attempts)
            {
                throw new Exception("Недостаточный банк");
            }
            else if (spots.Count == 15)
            {
                throw new Exception("Выбрано максимальное количество спотов");
            }
            
            spots.Add(val);
            return true;
        }

        bool IsValidSpot(int val)
        {
            return val >= 1 && val <= 80;
        }

        public List<int> GetSpots()
        {
            return spots;
        }

        public void Clear()
        {
            spots.Clear();
        }
    }
}
