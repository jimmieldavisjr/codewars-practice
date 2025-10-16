using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars.Year._2025.Month._8.Day._25.TwoSum.csharp
{
    // Codewars: Two Sum - 6 Kyu
    // Problem: https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp

    public class Kata
    {
        /// <summary>
        /// Finds two distinct elements in <paramref name="numbers"/> whose values sum to
        /// <paramref name="target"/> and returns their zero-based indices.
        /// </summary>
        /// <param name="numbers">Array of integers to search.</param>
        /// <param name="target">Sum to match.</param>
        /// <returns>Array of two zero-based indices that match the target.</returns>
        public static int[] TwoSum(int[] numbers, int target)
        {
            int[] arr = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        arr[0] = i;
                        arr[1] = j;

                        return arr;
                    }
                }
            }
            return arr;
        }
    }
}
