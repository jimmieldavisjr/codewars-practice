using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class KataRemoveVowel
{
    /*
    * Problem Description:
    * Remove all vowels from a given string. 
    */

    public static string Disemvowel(string str)
    {
        var result = new StringBuilder();
        foreach (char c in str)
        {
            char lower = char.ToLower(c);
            if (lower != 'a' && lower != 'e' && lower != 'i' && lower != 'o' && lower != 'u')
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }
}