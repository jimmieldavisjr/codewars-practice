
internal class InvertValues
{
    /*
    * Problem Description:
    * Given a set of numbers, return the additive inverse of each
    * [1, 2, 3, 4, 5] --> [-1, -2, -3, -4, -5]
    */

    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {

            if (input.Length == 0)
            {
                return new int[0];
            }

            else
            {

                int[] result = new int[input.Length];
                int count = 0;

                foreach (int num in input)
                {
                    result[count] = 0 - num;
                    count++;
                }
                return result;
            }
        }
    }
}
