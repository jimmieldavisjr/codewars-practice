using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars.Year._2025.Month._7.Day._24
{
    /// <summary>
    /// Provides functionality to validate the input pin code.
    /// </summary>
    /// <remarks>
    /// Codewars Challenge: Detect Pangram — 6 kyu.  
    /// 
    /// Problem: A pangram is a sentence that contains every single letter of the alphabet at least once. 
    /// For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it 
    /// uses the letters A-Z at least once (case is irrelevant). Given a string, detect whether or not it is a pangram. 
    /// Return True if it is, False if not.Ignore numbers and punctuation.
    /// 
    /// Example: 
    /// 
    /// Input: "The quick brown fox jumps over the lazy dog"
    /// Output: true
    /// </remarks>
    internal static class DetectPangram
    {
        /// <summary>
        /// Provides functionality to determine whether a given string is a pangram by calculating 
        /// the total value of all unique alphabetical characters and comparing it to the equivalent 
        /// value of a pangram (351) based on lowercase alphabetical letter ASCII values.
        /// </summary>
        /// <param name="str">Input string for evaluation.</param>
        /// <returns>
        /// True if the string is equivalent to a pangram, otherwise False.
        /// </returns>
        public static bool IsPangram(string str)
        {
            int testValue = 0;
            int pangramValue = 351;

            str = str.ToLower();
            string sorted = new string(str.OrderBy(c => c).ToArray());

            for (int i = 0; i < sorted.Length; i++)
            {
                if (i != sorted.Length - 1)
                {
                    if (char.IsLetter(sorted[i]))
                    {
                        if (sorted[i] != sorted[i + 1])
                        {
                            testValue += (int)sorted[i] - 96;
                        }
                    }
                }

                if (i == sorted.Length - 1)
                {
                    if (char.IsLetter(sorted[i]))
                    {
                        testValue += (int)sorted[i] - 96;
                    }
                }
            }

            if (testValue == pangramValue)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
