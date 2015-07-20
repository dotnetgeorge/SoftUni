/*
 * Problem 4.	Sequences of Equal Strings
 * Write a program that reads an array of strings and finds in it all sequences of equal elements 
 * (comparison should be case-sensitive). 
 * The input strings are given as a single line, separated by a space. 
 * Examples:
 * 
 * Input	            Output
 * hi yes yes yes bye	hi
 *                      yes yes yes
 *                      bye
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SequencesOfEqualStrings
{
    static void Main(string[] args)
    {
        Console.Write("Enter strings: ");
        string readStrings = Console.ReadLine();

        char[] separator = new char[] { ' ' };
        List<string> words = readStrings.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        PrintEqualStrings(words);
    }

    public static void PrintEqualStrings(List<string> words)
    {
        List<string> equalWords = new List<string>();
        List<string> checkedWords = new List<string>();
        int length = words.Count;
        string word = null;

        for (int i = 0; i < length; i++)
        {
            word = words[i];

            if (!checkedWords.Contains(word))
            {
                checkedWords.Add(word);
                equalWords = words.FindAll(x => word.Equals(x));

                equalWords.ForEach(x => Console.Write(x + " "));
                Console.WriteLine();
            }
        }
    }
}