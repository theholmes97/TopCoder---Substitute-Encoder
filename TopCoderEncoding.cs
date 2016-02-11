using System;
using System.Collections.Generic;
using System.Web;
public class Substitute
{
    //119 points out of 250

    public class Words
    {
        public int Position { get; set; }
        public string Letter { get; set; }
    }

    public static int getValue(string key, string code)
    {
        int i = 0;
        int z = 0;
        List<Words> k = new List<Words>();
        List<Words> c = new List<Words>();
        List<string> endcode = new List<string>();
        foreach (char y in key)
        {
            Words x = new Words();
            x.Letter = y.ToString();
            x.Position = i;
            k.Add(x);
            i++;
        }
        foreach (char y in code)
        {
            Words x = new Words();
            x.Letter = y.ToString();
            x.Position = z;
            c.Add(x);
            z++;
        }

        foreach (Words x in c)
        {
            if (c.Contains(x))
            {
                endcode.Add(x.Position.ToString());
            }
        }

        string concat = string.Join(" ", endcode.ToArray());
        int amount = int.Parse(Convert.ToInt32(concat));
        return amount;
    }
}

