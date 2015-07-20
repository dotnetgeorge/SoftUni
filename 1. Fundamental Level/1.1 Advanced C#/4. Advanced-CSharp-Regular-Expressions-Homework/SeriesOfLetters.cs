/*
 * Problem 1.	Series of Letters
 * Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
 * Input	                Output
 * aaaaabbbbbcdddeeeedssaa	abcdedsa
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class SeriesOfLetters
{
    public static string result = null;

    static void Main(string[] args)
    {
        Console.Write("Enter some string: ");
        string word = Console.ReadLine();

        result = RemoveRepeatetChars(word);

        Console.WriteLine(result);
    }

    public static string RemoveRepeatetChars(string word)
    {
        Regex regex = new Regex("(.)(?<=\\1\\1)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
        result = regex.Replace(word, String.Empty);

        return result;
    }
}