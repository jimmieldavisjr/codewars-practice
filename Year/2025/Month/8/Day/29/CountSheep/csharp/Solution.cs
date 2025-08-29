using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Codewars: Square Every Digit - 7 Kyu
// Problem: https://www.codewars.com/kata/546e2562b03326a88e000020/train/csharp

namespace Codewars.Year._2025.Month._8.Day._29.CountSheep.csharp
{
    /// <summary>
    /// Solution for the Count Sheep problem.
    /// </summary>
    internal class Solution
    {
        /// <summary>
        /// Counts every true value in <paramref name="sheeps"/> and returns the sum.
        /// </summary>
        /// <param name="sheeps">Array to iterate through.</param>
        /// <returns>The sum of all present sheep in Array <paramref name="sheeps"/>.</returns>
        public static int CountSheeps(bool[] sheeps)
        {
            int count = 0;

            foreach (bool b in sheeps)
            {
                if (b == true)
                {
                    count += 1;
                }
            }
            return count;
        }
    }
}
