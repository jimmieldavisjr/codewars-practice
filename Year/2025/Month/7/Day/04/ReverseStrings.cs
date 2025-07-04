using System.Text;

internal class ReverseStrings
{
    /*
    * Problem Description:
    * Complete the solution so that it reverses the string passed into it. 'world'  =>  'dlrow'
    */

    public static string Solution(string str)
    {
        var sb = new StringBuilder();

        for (int i = str.Length; i > 0; i--)
        {
            sb.Append(str[i - 1]);
        }
        return sb.ToString();
    }
}
