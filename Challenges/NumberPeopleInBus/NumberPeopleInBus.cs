
internal class NumberPeopleInBus
{
    /*
    * Problem Description:
    * List of type integer arrays
    * Your task is to return the number of people who are still on the bus after the last bus stop (after the last array).
    * Each element in list contains an array. 
    * First element in the array is number of people brought onto bus.
    * Last element in array is the number of people who departed the bus.
    */

    public static int Number(List<int[]> peopleListInOut)
    {
        int arrive = 0;
        int depart = 0;

        for (int i = 0; i < peopleListInOut.Count; i++)
        {
            arrive += peopleListInOut[i][0];
            depart += peopleListInOut[i][1];
        }
        return arrive - depart;
    }
}