using System.Text;

internal class DoubleChar
{
    public class Kata
    {
        public static string DoubleChar(string s)
        {
            var result = new StringBuilder();

            foreach (char c in s)
            {
                result.Append(c);
                result.Append(c);
            }

            return result.ToString();
        }
    }
}
