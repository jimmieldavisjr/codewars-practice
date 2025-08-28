using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Year._2025.Month._8.Day._27.TerminalGame.csharp
{
    // Codewars: Terminal Game - 8 Kyu
    // Problem: https://www.codewars.com/kata/563a631f7cbbc236cf0000c2/solutions/csharp

    internal class Solution
    {
        /// <summary>
        /// Doubles the <paramref name="roll"/> value and adds the current <paramref name="position"/> value
        /// and returns the sum.
        /// </summary>
        /// <param name="position">Current value to be added to the sum.</param>
        /// <param name="roll">Value doubled by itself added to the sum. </param>
        /// <returns>
        /// The sum as an integer from <paramref name="roll"/> doubled and added to <paramref name="position"/>.
        /// (e.g., <c>(5,4)</c> -> <c>13</c>)
        /// </returns>
        public static int Move(int position, int roll)
        {
            return (roll + roll) + position;
        }
    }
}