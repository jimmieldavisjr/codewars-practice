using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Year._2025.Month._7.Day._31.TotalPoints.csharp
{
    internal class Solution
    {
        public static int TotalPoints(string[] games)
        {
            int points = 0;

            for (int i = 0; i < games.Length; i++)
            {
                if (games[i][0] > games[i][2])
                {
                    points += 3;
                }

                if (games[i][0] == games[i][2])
                {
                    points += 1;
                }
            }
            return points;
        }
    }
}