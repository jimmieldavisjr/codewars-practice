using System.Text;

internal class WhoLikesIt
{
    /*
    * Problem Description:
    * Implement the function which takes an array containing the names of people that like an item. It must return the display text as shown in the examples:
    *   []                                -->  "no one likes this"
    *   ["Peter"]                         -->  "Peter likes this"
    *   ["Jacob", "Alex"]                 -->  "Jacob and Alex like this"
    *   ["Max", "John", "Mark"]           -->  "Max, John and Mark like this"
    *   ["Alex", "Jacob", "Mark", "Max"]  -->  "Alex, Jacob and 2 others like this"
    */

    public static string Likes(string[] name)
    {
        if (name.Length == 1)
        {
            return $"{name[0]} likes this";
        }

        else if (name.Length == 2)
        {
            return $"{name[0]} and {name[1]} like this";
        }

        else if (name.Length == 3)
        {
            return $"{name[0]}, {name[1]} and {name[2]} like this";
        }

        else if (name.Length > 3)
        {
            return $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
        }

        else
        {
            return "no one likes this";
        }
    }
}
