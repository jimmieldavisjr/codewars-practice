
internal class BinaryAddition
{
    /*
    * Problem Description:
    * Implement a function that adds two numbers together and returns their sum in binary. 
    */

    public static string AddBinary(int a, int b)
    {
        string binary = Convert.ToString((a + b), 2);
        return binary;
    }
}
