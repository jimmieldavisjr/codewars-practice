/// <summary>
/// Counts the total number of vowels in the specified string.
/// </summary>
/// <remarks>
/// Codewars Challenge: Vowel Count — 7 kyu.
/// 
/// Problem: Return the number (count) of vowels in the given string.
/// The vowels considered are: a, e, i, o, and u (lowercase only).
/// </remarks>
internal class VowelCount
{
    /// <summary>
    /// Calculates the total number of lowercase vowel characters in the input string.
    /// </summary>
    /// <param name="str">The string parameter to evaluate for vowel characters.</param>
    /// <returns>
    /// The total count of vowels as an integer.
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
