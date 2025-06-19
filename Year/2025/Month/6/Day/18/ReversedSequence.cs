
internal class ReversedSequence
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>

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