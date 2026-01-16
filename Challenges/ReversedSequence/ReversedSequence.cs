
internal class ReversedSequence
{
    /*
    * Problem Description:
    * Build a function that returns an array of integers from n to 1 where n>0.
    */

    public static int[] ReverseSeq(int n)
    {
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            arr[i] = n - i;
        }
        return arr;
    }
}