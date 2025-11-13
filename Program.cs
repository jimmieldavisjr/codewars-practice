using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
public class TopWords
{
    public static List<string> Top3(string s)
    {
        List<string> result = new List<string>();
        Dictionary<string, int> dict = new Dictionary<string, int>();
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                sb.Append(char.ToLower(s[i]));
                continue;
            }

            if (sb.Length > 0 && !char.IsLetter(s[i]))
            {
                if (!dict.ContainsKey(sb.ToString()))
                {
                    dict[sb.ToString()] = 1;
                }

                else
                {
                    dict[sb.ToString()] += 1;
                }
                sb.Length = 0;
            }
        }

        return dict
          .OrderByDescending(p => p.Value)
          .Take(3)
          .Select(p => p.Key)
          .ToList();
    }
}