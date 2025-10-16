/// <summary>
/// Provides functionality for calculating the multiplicative persistence of a given number.
/// </summary>
///
/// <remarks>
/// Codewars Challenge: Persistent Bugger. — 6 kyu.  
/// 
/// Problem: Write a function, persistence, that takes in a positive parameter 
/// <c>num</c> and returns its multiplicative persistence, which is the number 
/// of times you must multiply the digits in num until you reach a single digit. 
/// 
/// Example: 
/// Input: 39
/// Output: 3 — (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit, there are 3 multiplications)
/// </remarks>
internal class PersistentBugger
{
    /// <summary>
    /// Calculates the number of times the digits of the input number value must be multiplied together to reduce it to a single-digit number. 
    /// </summary>
    /// <param name="n">The positive input <c>long</c> value to evaluate.</param>
    /// <returns>
    /// The number of digit multiplications needed to reach a single-digit number. 
    /// </returns>
    public static int Persistence(long n)
    {
        int mp = 0;
        long mpValue = n;

        while (mpValue >= 10)
        {
            int test = 1;
            int[] x = Convert.ToString(mpValue).Select(c => c - '0').ToArray();

            for (int i = 0; i < x.Length; i++)
            {
                test *= x[i];
            }

            mpValue = test;
            mp++;
        }
        return mp;
    }
}