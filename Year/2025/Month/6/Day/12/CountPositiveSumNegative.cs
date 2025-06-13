using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CountPositiveSumNegative
{
    /*
    * Problem Description:
    * Return an array with the count of positive numbers and sum of negative numbers.
    */

    public static int[] CountPositivesSumNegatives(int[] input)
    {
        int[] arr = new int[2];

        if (input == null || input.Length == 0)
        {
            return new int[] { };
        }
        foreach (int num in input)
        {
            if (num > 0)
            {
                arr[0] += 1;
            }
            else if (num < 0)
            {
                arr[1] += num;
            }
        }
        return arr;
    }
}
