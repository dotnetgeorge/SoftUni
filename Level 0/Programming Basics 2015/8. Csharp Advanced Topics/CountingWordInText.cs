/*
 * Problem 16.	* Counting a Word in a Text
 * Write a program that counts how many times a given word occurs in given text. 
 * The first line in the input holds the word. 
 * The second line of the input holds the text. 
 * The output should be a single integer number – the number of word occurrences. 
 * Matching should be case-insensitive. 
 * Note that not all matching substrings are words and should be counted. 
 * A word is a sequence of letters separated by punctuation or start / end of text. 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class CountingWordInText
{
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter word to count: ");
        string countWord = Console.ReadLine();

        int count = CountOfWordInText(text, countWord);

        string result = ((count > 0) ? "Count of word in text is " + count : "Text doesn't contain this word: " + countWord);

        Console.WriteLine(result);
    }

    public static int CountOfWordInText(string text, string countWord)
    {
        int count = 1;
        int result;

        char[] separator = new char[] { ' ', '.', ',', '!', '@', '#', '$', '%', '^', '*', '(', ')', '-', '_', '=', '+', '\\', '/', '`', '\"' };
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            result = String.Compare(word, countWord, StringComparison.OrdinalIgnoreCase);

            if(result == 0)
            {
                count++;
            }
        }

        return count;
    }
}