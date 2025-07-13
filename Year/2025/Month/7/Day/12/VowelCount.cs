/// <summary>
/// Provides functionality for counting total occurrences of vowels in a string.
/// </summary>
///
/// <remarks>
/// Codewars Challenge: Vowel Count — 7 kyu.  
/// 
/// Problem: Return the number (count) of vowels in the given string.
/// </remarks>
internal class VowelCount
{
    /// <summary>
    /// Counts the total occurrences of vowels in the input string value     
    /// </summary>
    /// <param name="n">The input string containing possible vowels.</param>
    /// <returns>
    /// The total count of vowels as int.
    /// </returns>
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        foreach (char c in str)
        {
            switch (c)
            {
                case 'a':
                    vowelCount++;
                    break;

                case 'e':
                    vowelCount++;
                    break;

                case 'i':
                    vowelCount++;
                    break;

                case 'o':
                    vowelCount++;
                    break;

                case 'u':
                    vowelCount++;
                    break;
            }
        }
        return vowelCount;
    }
}
