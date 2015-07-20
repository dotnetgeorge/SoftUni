/*
 * Problem 14.	Longest Word in a Text
 * Write a program to find the longest word in a text. 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInText
{
    public static string longestWord;

    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        longestWord = LongestWord(text);

        Console.WriteLine("Longest word in text is: " + longestWord);
    }

    public static string LongestWord(string text)
    {
        char[] separator = new char[] { ' ', ',', '.', '!', '?', '@', '\\' };
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        longestWord = words.OrderByDescending(x => x.Length).First();

        return longestWord;
    }
}