using System.Text;

internal class KataDnaRnaCoversion
{
    /*
     * Problem Description:
     * 
     * Create a function which translates a given DNA string into RNA -> For example: "GCAT"  =>  "GCAU"
     */

    public string dnaToRna(string dna)
    {
        if (string.IsNullOrEmpty(dna))
        {
            return "No Input";
        }

        StringBuilder sb = new StringBuilder();

        foreach (char c in dna)
        {
            if (c == 'T')
            {
                sb.Append("U");
            }
            else
            {
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
}
