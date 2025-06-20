
internal class SquareSum
{
    /*
     * Problem Description:
     * 
     * Complete the method that takes a boolean value and return a "Yes" string for true, or a "No" string for false.
     */

    public static int SquareSum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num * num;
        }
        return sum;
    }
}
