
using System.Text;

internal class BreakCamelCase
{
    public static string BreakCamelCaseFunc(string str)
    {
        var sb = new StringBuilder();

        foreach (char c in str)
        {
            if (c < 96)
            {
                sb.Append(" ");
                sb.Append(c);
            }

            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}