/// <summary>
/// Provides functionality to determine whether a string is an isogram. 
/// </summary>
/// <remarks>
/// Codewars Challenge: Isograms — 7 kyu.  
/// 
/// Problem: An isogram is a word that has no repeating letters, consecutive or non-consecutive. 
/// Implement a function that determines whether a string that contains only letters is an isogram. 
/// Assume the empty string is an isogram. Ignore letter case.
/// 
/// Example: 
/// 
/// Input: "Dermatoglyphics" --> Output: true
/// Input: "aba" --> Output: false
/// </remarks>
internal class Isograms
{
    /// <summary>
    /// Determines whether the specified string is an isogram by checking for repeated characters.
    /// </summary>
    /// <param name="str">The input string to evaluate.</param>
    /// <returns>
    /// True or False if the string is an isogram.
    /// </returns>
    public static bool IsIsogram(string str)
    {
        char[] arr = str.ToCharArray();

        for (int i = 0; i < str.Length; i++)
        {
            for (int j = i + 1; j < str.Length; j++)
            {
                if (char.ToLower(arr[i]) == char.ToLower(arr[j]))
                {
                    return false;
                }
            }
        }
        return true;
    }
}
