/// <summary>
/// Provides functionality to validate the input pin code.
/// </summary>
/// <remarks>
/// Codewars Challenge: Regex Validate Pin Code — 7 kyu.  
/// 
/// Problem: ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot 
/// contain anything but exactly 4 digits or exactly 6 digits.
/// If the function is passed a valid PIN string, return true, else return false.
/// 
/// Example: 
/// 
/// Input: "1234"
/// Output: true
/// </remarks>
internal class ValidatePinCode
{
    /// <summary>
    /// Validates the input string to determine if it meets constraints by evaluating length and digit value.
    /// </summary>
    /// <param name="pin">The input string being evaluated.</param>
    /// <returns>
    /// True if valid input, otherwise false.
    /// </returns>
    public static bool ValidatePin(string pin)
    {
        if (pin.Length == 4 || pin.Length == 6)
        {
            foreach (char c in pin)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        else
        {
            return false;
        }
    }
}
