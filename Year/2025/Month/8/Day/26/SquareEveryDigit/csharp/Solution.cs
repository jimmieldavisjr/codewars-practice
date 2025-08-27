using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Year._2025.Month._8.Day._26.SquareEveryDigit.csharp
{
    // Codewars: Square Every Digit - 7 Kyu
    // Problem: https://www.codewars.com/kata/546e2562b03326a88e000020/train/csharp

    public class Kata
    {
        /// <summary>
        /// Squares then concatenates each digit in <paramref name="n"/> and returns
        /// the value as an integer.
        /// </summary>
        /// <param name="n">Digits to square and concatenate.</param>
        /// <returns>
        /// An integer from the digits that have been squared and concatenated.
        /// (e.g., <c>9119</c> -> <c>811181</c>)
        /// </returns>
        public static int SquareDigits(int n)
        {
            var sb = new StringBuilder();

            char[] arr = n.ToString().ToCharArray();

            foreach (char c in arr)
            {
                sb.Append(Convert.ToInt32(c.ToString()) * Convert.ToInt32(c.ToString()));
            }
            return Convert.ToInt32(sb.ToString());
        }
    }
}