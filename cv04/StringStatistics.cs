
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
 
 class StringStatistics
{
    public string input;
    public StringStatistics(string input)
    {
        this.input = input;
    }

    public static int wordCount(string x)
    {
        int count = 1;

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == ' ' || x[i] == '\n')
            {
                count++;
            }
        }
        return count;
    }

    public static int lineCount(string x)
    {
        int count = 1;

        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == '\n')
            {
                count++;
            }
        }
        return count;
    }

    public static int sentenceCount(string x)
    {
        int count = 0;
        x = x.Replace('\n', ' ');


        for (int i = 0; i < x.Length; i++)
        {
            if (x[i] == '?' || x[i] == '!' || x[i] == '.' && i == x.Length - 1)
            {
                count++;
            }
        }
        for (int i = 0; i + 2 < x.Length; i++)
        {
            if (x[i] == '.' && x[i + 1] == ' ' && char.IsUpper(x[i + 2]))
            {
                count++;
            }
        }
        return count;
    }

    public static string longestWord(string x)
    {
        x = x.Replace('\n', ' ');

        string[] array = x.Split();
        string refer = "";
        string longest = "";
        foreach (string s in array)
        {
            if (s.Length > refer.Length)
            {
                refer = s;
                longest = s;
            }
            else if (s.Length == refer.Length)
            {
                longest = longest + "," + s;
            }
        }
        return longest;
    }

    public static string shortesttWord(string x)
    {
        x = x.Replace('\n', ' ');

        string[] array = x.Split();
        string refer = array[0];
        string shortest = array[0];
        foreach (string s in array)
        {
            if (s.Length < refer.Length)
            {
                refer = s;
                shortest = s;
            }
            else if (s.Length == refer.Length)
            {
                shortest = shortest + "," + s;
            }
        }
        return shortest;
    }
    public static string mostWord(string x)
    {
        Dictionary<string, int> tmp = new Dictionary<string, int>();
        string result = "";
        int max = 0;
        x = x.Replace("\n", " ");
        x = x.Replace(",", "");
        x = x.Replace(".", "");
        x = x.Replace("!", "");
        x = x.Replace("?", "");
        x = x.Replace("(", "");
        x = x.Replace(")", "");

        string[] array = x.Split();

        foreach (string s in array)
        {
            if (tmp.ContainsKey(s))
            {
                tmp[s]++;
            }
            else
            {
                tmp.Add(s, 1);
            }
        }

        foreach (KeyValuePair<string, int> pair in tmp)
        {
            if (pair.Value > max)
            {
                max = pair.Value;
                result = pair.Key;
            }
        }

        return result;

    }

    public static string alphabeticOrder(string x)
    {
        List<string> tmp = new List<string>();
        string result = "";
        x = x.Replace("\n", " ");
        x = x.Replace(",", "");
        x = x.Replace(".", "");
        x = x.Replace("!", "");
        x = x.Replace("?", "");
        x = x.Replace("(", "");
        x = x.Replace(")", "");

        string[] array = x.Split();

        foreach (string s in array)
        {
            tmp.Add(s);
        }
        tmp.Sort();

        foreach (string s in tmp)
        {
            result += s + ",";
        }
        return result;
    }
}