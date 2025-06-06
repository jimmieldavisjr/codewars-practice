using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal class KataKeepHydrated
    {
        /*
         * Problem Description:
         * Because Nathan knows it is important to stay hydrated, he drinks 0.5 litres of water per hour of cycling.
         * You get given the time in hours and you need to return the number of litres Nathan will drink, rounded down.
         */

        public static int Litres(double time)
        {
            return Convert.ToInt32(Math.Floor(time)) / 2;
        }
    }
