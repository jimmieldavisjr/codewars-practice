using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Challenges.FindNeedle
{
    internal class Solution
    {
        public static string FindNeedle(object[] haystack)
        {
            int i = 0;
            foreach (object item in haystack)
            {
                if (item is string s && s == "needle")
                {
                    return $"found the needle at position {i}";
                }
                else
                {
                    i++;
                }
            }
            return "No items found";
        }
    }
}