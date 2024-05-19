using System;
using System.Collections.Generic;
using System.Linq;


namespace KenoGame.Keno
{
    public class Attempt
    {
        public List<int> GenerateWinningSpots(int n = 15)
        {
            List<int> spots = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                var spot = rnd.Next(1, 80);
                if (spots.Contains(spot))
                {
                    i -= 1;
                }
                else
                {
                    spots.Add(spot);
                }
            }
            return spots;
        }

        public double CalculateWinning(List<int> selectedSpots, List<int> winningSpots, double bet)
        {
            var crossing = selectedSpots.Intersect(winningSpots).ToList();
            var result = Math.Floor(Math.Pow((double)crossing.Count() * 3 / selectedSpots.Count(), 2) * (1 + bet));
            return result;
        }
    }
}
