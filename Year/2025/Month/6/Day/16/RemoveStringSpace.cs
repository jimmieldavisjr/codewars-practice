using System.Text;

internal class RemoveStringSpace
{
    /*
    * Problem Description:
    * Write a function that removes the spaces from the string, then return the resultant string.
    */

    public static class SpacesRemover
    {
        public static string NoSpace(string input)
        {
            var result = new StringBuilder();

            foreach (char letter in input)
            {
                if (letter != ' ')
                {
                    result.Append(letter);
                }
            }
            return result.ToString();
        }
    }
}

