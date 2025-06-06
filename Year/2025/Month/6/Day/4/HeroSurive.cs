using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class HeroSurive
{
    /*
     * Problem Description:
     * Each dragon takes 2 bullets to kill.
     * Hero has unknown amount of bullets.
     * Return true if he has enough to kill dragons, or false otherwise.
     */

    public static bool Hero(int bullets, int dragons)
    {
        return bullets >= dragons * 2;
    }
}

