
internal class TitleCasingStrings
{
    /*
    * Problem Description:
    * Return string in the Jade-Cased format.
    * Not Jaden-Cased: "How can mirrors be real if our eyes aren't real"
    * Jaden-Cased: "How Can Mirrors Be Real If Our Eyes Aren't Real"
    */

    public static string ToJadenCase(string phrase)
    {
        char[] arr = new char[phrase.Length];
        for (int i = 0; i < phrase.Length; i++)
        {
            if (i == 0 || phrase[i - 1] == ' ')
            {
                arr[i] = char.ToUpper(phrase[i]);
                continue;
            }

            else
            {
                arr[i] = phrase[i];
            }
        }
        return new string(arr);
    }
}
