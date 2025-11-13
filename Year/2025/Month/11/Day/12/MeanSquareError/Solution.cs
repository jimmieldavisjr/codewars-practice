using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
