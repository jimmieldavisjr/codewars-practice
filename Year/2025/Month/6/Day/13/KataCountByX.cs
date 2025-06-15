
internal class KataCountByX
{
    /*
    * Problem Description:
    * Create a function with two arguments that will return an array of the first n multiples of x.
    * x = 1, n = 10 --> [1,2,3,4,5,6,7,8,9,10]
    * x = 2, n = 5  --> [2,4,6,8,10]
    */

    public static int[] CountBy(int x, int n)
    {
        int[] z = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (i == 0)
            {
                z[i] = x;
            }
            else if (i > 0)
            {
                z[i] = z[i - 1] + x;
            }
        }
        return z;
    }
}