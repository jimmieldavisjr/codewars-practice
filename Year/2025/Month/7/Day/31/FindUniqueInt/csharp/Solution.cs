using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Year._2025.Month._7.Day._31.FindUniqueInt.csharp
{
    internal class Solution
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            int[] arr = numbers.ToArray();
            int equal = arr[0] == arr[1] ? arr[0] : arr[2];

            foreach (int num in arr)
            {
                if (num != equal)
                {
                    return num;
                }
            }
            return 0;
        }
    }
}