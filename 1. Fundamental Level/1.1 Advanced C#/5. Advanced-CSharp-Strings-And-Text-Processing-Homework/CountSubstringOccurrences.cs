/*
 * Problem 3.	Count Substring Occurrences
 * Write a program to find how many times a given string appears in a given text as substring. 
 * The text is given at the first input line. 
 * The search string is given at the second input line. 
 * The output is an integer number. Please ignore the character casing. 
 * Overlapping between occurrences is allowed. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CountSubstringOccurrences
{
    public static int count;

    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter substring: ");
        string substring = Console.ReadLine();

        count = CountSubstring(text, substring);

        Console.WriteLine("'{0}' found {1} time/s in text: ", substring, count);
    }

    public static int CountSubstring(string text, string substring)
    {
        text = text.ToLower();
        int index = text.IndexOf(substring);
        count = 0;

        while (index != -1)
        {
            index = text.IndexOf(substring, index + 1);
            count++;
        }

        return count;
    }
}