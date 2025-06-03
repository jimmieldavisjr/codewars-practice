using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Codewars._2025._5._30
{
    internal class KataWillYouMakeIt
    {
        /*
         * Problem Description:
         * You are camping far from home and need to return, but your fuel is low.
         * The nearest fuel pump is 50 miles away. Your car averages 25 miles per gallon,
         * and you have 2 gallons of fuel remaining.
         *
         * Write a function that determines whether you can reach the pump.
         * The function should return true if the distance can be covered, false otherwise.
         */

        public static bool ZeroFuelA(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            if (mpg * fuelLeft >= distanceToPump)
            {
                Console.WriteLine("True");
                return true;
            }    
            else
            {
                Console.WriteLine("False");
                return false;
            }
        }

        public static bool ZeroFuelB(uint distanceToPump, uint mpg, uint fuelLeft)
        {
            return mpg * fuelLeft >= distanceToPump;
        }
    }
}
