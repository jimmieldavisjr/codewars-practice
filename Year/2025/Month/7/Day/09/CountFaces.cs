/// <summary>
/// Provides functionality to count the number of valid smiley face strings in an array based on allowed characters and format rules.
/// </summary>
/// <remarks>
/// Codewars Solution: "Count the Smiley Faces!" — 6 kyu.  
/// Valid smiley faces must follow this pattern:
/// - Eyes: ':' or ';'
/// - Optional nose: '-' or '~'
/// - Mouth: ')' or 'D'
/// Examples of valid faces: :) :D ;-D :~)
/// Examples of invalid faces: ;( :> :} :]
/// </remarks>
internal class CountFaces
{
    /// <summary>
    /// Counts the number of valid smiley face strings in the provided array based on defined facial component rules.
    /// </summary>
    /// <param name="smileys">An array of strings, each potentially representing a smiley face.</param>
    /// <returns>
    /// The total count of strings that represent valid smiley faces.
    /// </returns>
    public static int CountSmileys(string[] smileys)
    {
        int count = 0;

        foreach (string s in smileys)
        {
            if (s.Length == 3)
            {
                if (s[0] == ':' || s[0] == ';')
                {
                    if (s[1] == '-' || s[1] == '~')
                    {
                        if (s[2] == ')' || s[2] == 'D')
                        {
                            count += 1;
                        }
                    }
                }
            }

            else if (s.Length == 2)
            {
                if (s[0] == ':' || s[0] == ';')
                {
                    if (s[1] == ')' || s[1] == 'D')
                    {
                        count += 1;
                    }
                }
            }
        }
        return count;
    }
}
