internal class Solution
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        int[] arr = { numbers[0] < numbers[1] ? numbers[0] : numbers[1], numbers[0] < numbers[1] ? numbers[1] : numbers[0] };
        int count = 0;

        foreach (int num in numbers)
        {
            if (count > 1)
            {
                if (num < arr[0])
                {
                    arr[1] = arr[0];
                    arr[0] = num;
                }

                else if (num < arr[1])
                {
                    arr[1] = num;
                }
            }
            count++;
        }
        return arr[0] + arr[1];
    }
}
