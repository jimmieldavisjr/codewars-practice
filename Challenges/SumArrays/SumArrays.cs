
internal class SumArrays
{
    /*
    * Problem Description:
    * Write a function that takes an array of numbers and returns the sum of the numbers. The numbers can be negative or non-integer. If the array does not contain any numbers then you should return 0.
    */

    public static double SumArray(double[] array)
    {
        if (array.Length == 0)
        {
            return 0;
        }
        double result = 0;

        foreach (double num in array)
        {
            result += num;
        }
        return result;
    }
}