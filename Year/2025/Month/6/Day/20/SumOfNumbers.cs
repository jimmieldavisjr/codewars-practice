
internal class SumOfNumbers
{
    /*
     * Problem Description:
     * Given two integers a and b, which can be positive or negative, find the sum of all the integers between and including them and return it. If the two numbers are equal return a or b.
     */

    public class Sum
    {
        public int GetSum(int a, int b)
        {
            int result = 0;

            if (a == b)
            {
                return a;
            }

            else if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    result += i;
                }
                return result;
            }

            else if (b < a)
            {
                for (int i = b; i <= a; i++)
                {
                    result += i;
                }
                return result;
            }

            return result;
        }
    }
}
