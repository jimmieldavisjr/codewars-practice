
internal class SquareNum
{
    /*
    * Problem Description:
    * Given an integral number, determine if it's a square number:
    */

    public static bool IsSquare(int n)
    {
        if (n < 0)
        {
            return false;
        }

        if (Math.Sqrt(n) == Math.Floor(Math.Sqrt(n)))
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}