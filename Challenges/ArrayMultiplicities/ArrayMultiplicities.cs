internal static class ArrayMultiplicities
{
    public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null || a.Length == 0 || b.Length == 0 || a.Length != b.Length)
        {
            return false;
        }

        if (a.Length == 0 && b.Length == 0)
        {
            return true;
        }

        var listA = a.ToList();
        var listB = b.ToList();

        foreach (var num in listA)
        {
            int Squared = num * num;
            if (listB.Contains(Squared))
            {
                listB.Remove(Squared);
            }

            else
            {
                return false;
            }
        }
        return listB.Count == 0;
    }
}

