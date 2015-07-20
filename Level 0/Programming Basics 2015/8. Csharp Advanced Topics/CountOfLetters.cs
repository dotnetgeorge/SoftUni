/*
 * Problem 11.	Count of Letters
 * Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
 * The letters should be listed in alphabetical order. 
 * Use the input and output format from the examples below. 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class CountOfLetters
{
    public static SortedDictionary<char, int> countOfLetters;

    static void Main(string[] args)
    {
        Console.Write("Enter letters: ");
        string readLetters = Console.ReadLine();

        char[] separator = new char[] { ' ' };
        //List<string> letters = readLetters.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        char[] letters = readLetters.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Char.Parse).ToArray();

        countOfLetters = FindCountOfLetters(letters);

        PrintCountOfLetters(countOfLetters);

    }

    public static SortedDictionary<char, int> FindCountOfLetters(char[] letters)
    {
        countOfLetters = new SortedDictionary<char, int>();
        int length = letters.Length;
        int count = 0;
        char letter = '\0';

        Array.Sort(letters);

        for (int i = 0; i < length; i++)
        {
            letter = letters[i];

            if(!countOfLetters.ContainsKey(letter))
            {
                count = letters.Count(x => x.Equals(letter));

                countOfLetters.Add(letter, count);
            }
        }


        return countOfLetters;
    }

    public static void PrintCountOfLetters(SortedDictionary<char, int> countOfLetters)
    {
        foreach (var item in countOfLetters)
        {
            Console.WriteLine("{0} -> {1}", item.Key, item.Value);
        }
    }
}