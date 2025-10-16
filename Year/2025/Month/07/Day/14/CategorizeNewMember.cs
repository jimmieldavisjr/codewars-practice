/// <summary>
/// Provides functionality to categorize each club member as either "Senior" or "Open" based upon defined criteria.
/// </summary>
///
/// <remarks>
/// Codewars Challenge: Categorize New Member — 7 kyu.  
/// 
/// Problem: The Western Suburbs Croquet Club has two categories of membership, Senior and Open. 
/// They would like your help with an application form that will tell prospective members which category 
/// they will be placed.To be a senior, a member must be at least 55 years old and have a handicap greater than 7. 
/// In this croquet club, handicaps range from -2 to +26; the better the player the lower the handicap.
/// 
/// Example: 
/// 
/// Input: [[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]
/// Output: ["Open", "Open", "Senior", "Open", "Open", "Senior"]
/// </remarks>
internal class CategorizeNewMember
{
    /// <summary>
    /// Categorizes each member as "Senior" or "Open" based on age and handicap.
    /// </summary>
    /// <param name="data">An array parameter containing integer based arrays to be evaluated, where each array contains two values: 
    /// [0] = age, [1] = handicap.
    /// </param>
    /// <returns>
    /// A list of assigned member categories.
    /// </returns>
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
        List<string> tempList = new List<string>(data.Length);
        IEnumerable<string> finalList = tempList;

        foreach (int[] num in data)
        {
            if (num[0] >= 55 && num[1] > 7)
            {
                tempList.Add("Senior");
            }
            else
            {
                tempList.Add("Open");
            }
        }
        return finalList;
    }
}
