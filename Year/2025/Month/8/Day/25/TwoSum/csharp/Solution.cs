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

    /// <summary>
    /// Provides functionality to calculate the sum of two indexes to find the target in an array.
    /// </summary>
    public class Kata
    {
        /// <summary>
        /// Calculates the sum by iterating through the integer array.
        /// </summary>
        /// <param name="numbers">The input integer array for evaluation.</param>
        /// <param name="target">The input integer to find from the given array.</param>
        /// <returns>The sum of two indexes within an array equivalent to the target.</returns>
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
