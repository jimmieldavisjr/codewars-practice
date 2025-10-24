using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Codewars: Testing 1-2-3 - 7 Kyu
// Problem: https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp

namespace Codewars.Year._2025.Month._10.Day._24.Testing1_2_3.csharp
{
    internal class Solution
    {
        public static List<string> Number(List<string> lines)
        {
            List<string> result = new List<string>();
            int curr = 1;

            for (int i = 0; i < lines.Count; i++)
            {
                result.Add($"{curr}: {lines[i]}");
                curr++;
            }

            return result;
        }
    }
}
