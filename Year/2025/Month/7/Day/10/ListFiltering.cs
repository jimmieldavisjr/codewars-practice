/// <summary>
/// Provides functionality to filter out string values from a list of objects, returning only integer values.
/// </summary>
/// <remarks>
/// Codewars Solution: List Filtering — 7 kyu.  
/// Problem: Create a function that takes a list containing non-negative integers and strings, and returns a new list with the strings removed.
/// </remarks>
internal class ListFiltering
{
    /// <summary>
    /// Extracts and returns all integer values from a list containing both integers and strings.
    /// </summary>
    /// <param name="listOfItems">A list containing elements of type <c>int</c> and <c>string</c>.</param>
    /// <returns>
    /// An list of integers filtered from the input list.
    /// </returns>
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> intList = new List<int>();
        foreach (object item in listOfItems)
        {
            if (item is int value)
            {
                intList.Add(value);
            }
        }
        return intList;
    }
}