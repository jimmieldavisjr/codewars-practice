/// <summary>
/// Provides functionality to filter repeated items from a sequence of elements.
/// </summary>
/// <remarks>
/// Codewars Challenge: Unique In Order — 6 kyu.  
/// 
/// Problem: Implement the function unique_in_order which takes as argument a sequence 
/// and returns a list of items without any elements with the same value next 
/// to each other and preserving the original order of elements.
/// 
/// Example: 
/// 
/// Input: uniqueInOrder("AAAABBBCCDAABBB")
/// Output: {'A', 'B', 'C', 'D', 'A', 'B'}
/// </remarks>
internal class Unique
{
    /// <summary>
    /// Filters the input sequence to create new sequence list by comparing each item to its predecessor.
    /// </summary>
    /// <typeparam name="T">The type of elements in the input sequence.</typeparam>
    /// <param name="iterable">The input sequence for filtering repeated elements.</param>
    /// <returns>
    /// A new sequence of non-repeated elements.
    /// </returns>
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        List<T> arg = new List<T>(iterable);
        List<T> list = new List<T>();

        for (int i = 0; i < arg.Count; i++)
        {
            if (i == 0)
            {
                list.Add(arg[i]);
            }

            if (i != 0)
            {
                if (!EqualityComparer<T>.Default.Equals(arg[i], arg[i - 1]))
                {
                    list.Add(arg[i]);
                }
            }
        }
        return list;
    }
}
