using System.Text;

/// <summary>
/// Provides a method for transforming a non-empty, non-null string of digit characters into a "fake binary" representation.
/// </summary>
/// <remarks>
/// Codewars Solution: Fake Binary — 8 kyu.  
/// Problem: Given a string of digits, replace any digit below 5 with '0' and any digit 5 or above with '1'.  
/// The input is guaranteed to be a non-empty string of numeric characters ('0'–'9').
/// </remarks>
internal class FakeBinary
{
    /// <summary>
    /// Transforms a sequence of digit characters into a new string,
    /// where each digit is replaced with '0' if less than 5, or '1' if greater than or equal to 5.
    /// </summary>
    /// <param name="x">A non-null, non-empty string consisting only of digit characters ('0'–'9').</param>
    /// <returns>
    /// A new string of equal length to the input string, where each digit character is mapped to either '0' or '1'
    /// based on a threshold comparison against the value 5.
    /// </returns>
    public static string FakeBin(string x)
    {
        var sb = new StringBuilder();

        foreach (char c in x)
        {
            if (c < '5')
            {
                sb.Append('0');
            }
            else
            {
                sb.Append('1');
            }
        }
        return sb.ToString();
    }
}