using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class FindMinMaxInt
{
    /*
    * Problem Description:
    * Find and return lowest integer in array
    * Find and return highest integer in array
    */

    public int Min(int[] list)
    {
        int lowest = list[0];

        foreach (int num in list)
        {
            if (num < lowest)
            {
                lowest = num;
            }
        }
        return lowest;
    }

    public int Max(int[] list)
    {
        int highest = list[0];

        foreach (int num in list)
        {
            if (num > highest)
            {
                highest = num;
            }
        }
        return highest;
    }
}
