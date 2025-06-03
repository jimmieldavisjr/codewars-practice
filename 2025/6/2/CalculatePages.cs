using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._2025._6._2
{
    internal class CalculatePages
    {
        /*
         * Problem Description:
         * 
         * Your classmates asked you to copy some paperwork for them. You know that there are 'n' classmates and the paperwork has 'm' pages.
         * Your task is to calculate how many blank pages do you need. If n < 0 or m < 0 return 0.
         */

        public static int Paperwork(int n, int m)
        {
            return n < 0 || m < 0 ? 0 : m * n;
        }
    }
}