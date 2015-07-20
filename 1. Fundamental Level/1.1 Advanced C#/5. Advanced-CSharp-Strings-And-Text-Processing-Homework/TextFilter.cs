/*
 * Problem 4.	Text Filter
 * Write a program that takes a text and a string of banned words. 
 * All words included in the ban list should be replaced with asterisks "*", equal to the word's length. 
 * The entries in the ban list will be separated by a comma and space ", ".
 * The ban list should be entered on the first input line and the text on the second input line. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class TextFilter
{

    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        Console.Write("Enter words to censore: ");
        string readWords = Console.ReadLine();

        string censoredText = CensoreText(text, readWords);

        Console.WriteLine(censoredText);
    }

    public static string CensoreText(string text, string readWords)
    {
        char[] separator = new char[] { ',', ' ' };
        string[] words = readWords.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int length = words.Length;
        int replaceLength = 0;
        string word = null;
        string replace = null;
        
        for (int i = 0; i < length; i++)
        {
            word = words[i];
            replaceLength = word.Length;
            replace = new string('*', replaceLength);

            text = text.Replace(word, replace);
        }

        return text;
    }
}