using static RemoveFirstLastChar;

/// <summary>
/// Provides functionality for returning the negation of an integer.
/// </summary>
/// 
/// <remarks>
/// Codewars Challenge: Return Negative — 8 kyu.  
/// 
/// Problem: In this simple assignment you are given a number and have to make it negative. 
/// 
/// Example: 
/// Kata.MakeNegative(1);  // return -1
/// Kata.MakeNegative(-5); // return -5
/// Kata.MakeNegative(0);  // return 0
/// </remarks>
internal class ReturnNegative
{
    /// <summary>
    /// Converts the input integer to negative by applying the negation operator.
    /// </summary>
    /// <param name="number">The integer to be converted to its negative form</param>
    /// <returns>
    /// A negative version of the input integer. Returns the input integer unchanged if already zero or negative.
    /// </returns>
    public static int MakeNegative(int number)
    {
        if (number <= 0)
        {
            return number;
        }
        else
        {
            return -number;
        }
    }
}