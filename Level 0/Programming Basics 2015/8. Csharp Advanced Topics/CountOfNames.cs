using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    public static SortedDictionary<string, int> countOfNames;

    static void Main(string[] args)
    {
        Console.Write("Enter letters: ");
        string readNames = Console.ReadLine();

        char[] separator = new char[] { ' ' };
        List<string> names = readNames.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        //char[] letters = readLetters.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Char.Parse).ToArray();

        countOfNames = FindCountOfLetters(names);

        PrintCountOfLetters(countOfNames);
    }

    public static SortedDictionary<string, int> FindCountOfLetters(List<string> names)
    {
        countOfNames = new SortedDictionary<string, int>();
        int length = names.Count;
        int count = 0;
        string name = null;

        names.Sort();

        for (int i = 0; i < length; i++)
        {
            name = names[i];

            if (!countOfNames.ContainsKey(name))
            {
                count = names.Count(x => x.Equals(name));

                countOfNames.Add(name, count);
            }
        }


        return countOfNames;
    }

    public static void PrintCountOfLetters(SortedDictionary<string, int> countOfNames)
    {
        foreach (var item in countOfNames)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}