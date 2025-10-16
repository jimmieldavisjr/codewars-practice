
internal class FindMinMax
{
    /*
    * Problem Description:
    * Write a function that returns both the minimum and maximum number of the given list/array.
    */

    public static int[] MinMax(int[] lst)
    {
        int low = 0;
        int high = 0;

        for (int i = 0; i < lst.Length; i++)
        {
            if (i == 0)
            {
                low = lst[i];
                high = lst[i];
            }

            else if (lst[i] >= high)
            {
                high = lst[i];
            }

            else if (lst[i] <= low)
            {
                low = lst[i];
            }
        }
        return new int[] { low, high };
    }
}