
internal class ReturningStrings
{
    /*
     * Problem Description:
     * Create a function that accepts a parameter representing a name and returns the message: "Hello, <name> how are you doing today?"
     */

    public static string Greet(string name)
    {
        return new string($"Hello, {name} how are you doing today?");
    }
}