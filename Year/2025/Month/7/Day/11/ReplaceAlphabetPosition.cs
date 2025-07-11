using System.Text;

/// <summary>
/// Provides functionality to convert letters in a string to their corresponding alphabetical positions.
/// </summary>
/// 
/// <remarks>
/// Codewars Challenge: Replace With Alphabet Position — 6 kyu.  
/// 
/// Problem: Given a string, replace every letter with its position in the alphabet (a = 1, b = 2, ..., z = 26).  
/// Non-letter characters are ignored.
/// 
/// Example:
/// Input:  "The sunset sets at twelve o' clock."
/// Output: "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"
/// </remarks>
internal class ReplaceAlphabetPosition
{
    /// <summary>
    /// Converts each alphabetical character in the input string to its 1-based position in the alphabet.
    /// Non-letter characters are ignored.
    /// </summary>
    /// 
    /// <param name="text">The input string to convert.</param>
    /// 
    /// <returns>
    /// A space-separated string of numbers representing the alphabetical positions of each letter in the input.
    /// </returns>
    public static string AlphabetPosition(string text)
    {
        var sb = new StringBuilder();

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                int pos = (char.ToLower(c) - 'a') + 1;
                sb.Append(pos + " ");
            }
        }
        return sb.ToString().Trim();
    }
}
