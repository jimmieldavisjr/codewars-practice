using System.Text;

internal class ReverseWords
{
    /*
    * Problem Description:
    * Reverse characters in string. 
    * Keep spaces in String at the same location.
    */

    public static string ReverseWordsFunc(string str)
    {
        var result = new StringBuilder();
        var word = new StringBuilder();

        foreach (char c in str)
        {
            if (c != ' ')
            {
                word.Append(c);
            }

            else
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result.Append(word[i]);
                }
                result.Append(' ');
                word.Clear();
            }
        }

        for (int i = word.Length - 1; i >= 0; i--)
        {
            result.Append(word[i]);
        }

        return result.ToString();
    }
}
