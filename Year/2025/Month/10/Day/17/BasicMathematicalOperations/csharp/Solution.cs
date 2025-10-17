using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Codewars: Basic Mathematical Operations - 8 Kyu
// Problem: https://www.codewars.com/kata/57356c55867b9b7a60000bd7

namespace BasicMathmaticalOperatorsCsharp
{
    public class Solution
    {
        public static double basicOp(char operation, double value1, double value2)
        {
            switch (operation)
            {
                case '+':
                    return value1 + value2;
                case '-':
                    return value1 - value2;
                case '/':
                    return value1 / value2;
                case '*':
                    return value1 * value2;

                default:
                    return 0.0;
            }
        }
    }
}
