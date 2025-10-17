using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

// Codewars: Debug Say Hello - 8 Kyu
// Problem: https://www.codewars.com/kata/5625618b1fe21ab49f00001f/train/csharp

namespace SayHelloDebugCsharp
{
    public class Solution
    {
        public static string SayHello(string name)
        {
            return $"Hello, {name}";
        }
    }
}