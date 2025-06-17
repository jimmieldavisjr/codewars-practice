using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class EvenOrOdd
{
    public static string EvenOrOdd(int number)
    {
        if (number % 2 == 0)
        {
            Console.WriteLine("Even");
            return "Even";
        }
        else
        {
            Console.WriteLine("Odd");
            return "Odd";
        }
    }
}

