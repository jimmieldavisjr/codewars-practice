using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._2025._5._30
{
    internal class ConvertBoolToString
    {
        /*
         * Problem Description:
         * Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
         */

        public static string boolToWord(bool word)
        {
            if (word == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }
    }
}
