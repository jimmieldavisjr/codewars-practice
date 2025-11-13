using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Codewars: Mean Square Error - 5 Kyu
// Problem: https://www.codewars.com/kata/51edd51599a189fe7f000015/train/csharp/69153ed6b6361f67f02b6e63

namespace Codewars.Year._2025.Month._11.Day._12.MeanSquareError
{
    internal class Solution
    {
        public static double MeanSquareError(int[] firstArray, int[] secondArray)
        {
            int len = firstArray.Length;
            double res = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {
                int temp = (secondArray[i] - firstArray[i]);
                res += temp * temp;
            }

            res = res / len;

            return res;
        }
    }
}

