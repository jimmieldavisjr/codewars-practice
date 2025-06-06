using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class KataRemoveFirstLastChar
{
    /*
    * Problem Description:
    * Remove first and last character of a String.
    * Strings will not be less than 2 characters.
    */


    public class Kata
    {
        public static string Remove_char(string s)
        {
            StringBuilder sb = new StringBuilder();
            char[] c = s.ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {
                if (i != 0 && i != s.Length - 1)
                {
                    sb.Append(c[i]);
                }
            }
            return sb.ToString();
        }
    }
}
