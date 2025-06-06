using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class KataReduceButGrow
    {
        /*
        * Problem Description:
        * Given a non-empty array of integers, return the result of multiplying the values together in order.
        */

        public static int Grow(int[] x)
        {
            int product = 1;

            foreach (int num in x)
            {
                product = product * num;
            }
            return product;
        }
    }
