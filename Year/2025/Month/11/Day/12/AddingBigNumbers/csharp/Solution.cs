using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

// Codewars: Adding Big Numbers - 4 Kyu
// Problem: https://www.codewars.com/kata/525f4206b73515bffb000b21

namespace Codewars.Year._2025.Month._11.Day._12.AddingBigNumbers.csharp
{
    internal class Solution
    {

        public static string Add(string a, string b)
        {
            BigInteger total = 0;

            total = BigInteger.Parse(a) + BigInteger.Parse(b);

            return total.ToString();
        }
    }
}