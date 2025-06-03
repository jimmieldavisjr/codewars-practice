using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._2025._5._30
{
    internal class KataCalculateAverage
    {
        /*
         * Problem Description:
         * 
         * Write a function which calculates the average of the numbers in a given array.
         * Note: Empty arrays should return 0.
         */

        public static double FindAverage(double[] array)
        {
            double avg = 0;
            double total = 0;

            if (array.Length == 0) return 0;

            foreach (double number in array)
            {
                total += number;
            }

            avg = total / array.Length;

            Console.WriteLine(avg);
            return avg;
        }
    }
}
