
internal class Summation
{
    /*
    * Problem Description:
    * Return the Summation of a given number.
    * Example: Summation of 8 is 36.
    */

    public static int summation(int num)
    {
        int result = 0;

        for (int i = 1; i <= num; i++)
        {
            result = result + i;
        }

        return result;
    }
}
