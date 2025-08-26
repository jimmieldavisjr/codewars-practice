using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Year._2025.Month._7.Day._31.TotalPoints.csharp
{
    // Codewars: Total Amount of Points - 8 Kyu
    // https://www.codewars.com/kata/5bb904724c47249b10000131/train/csharp

    /// <summary>
    /// Provides functionality to calculate the total amount of points based of criteria.
    /// </summary>
    internal class Solution
    {
        /// <summary>
        /// Calculates the total points by iterating through the string array 
        /// input parameter and comparing each items first and last values based on point rules.
        /// </summary>
        /// <param name="games">The input array string for evaluation.</param>
        /// <returns></returns>
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