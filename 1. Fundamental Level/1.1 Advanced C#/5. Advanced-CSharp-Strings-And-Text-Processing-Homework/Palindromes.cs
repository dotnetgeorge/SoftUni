/*
 * Problem 6.	Palindromes
 * Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe
 * and prints them on the console on a single line, separated by comma and space. 
 * Use spaces, commas, dots, question marks and exclamation marks as word delimiters. 
 * Print only unique palindromes, sorted lexicographically.
 */
using System;
using System.Collections.Generic;

class Palindromes
{
    public static SortedSet<string> palindromes;
    public static char[] separator = new char[] { ' ', ',', '.', '!', '?' };
    public static int length;

    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        palindromes = ExtractPalindromes(text);

        PrintPalindromes(palindromes);
    }

    public static SortedSet<string> ExtractPalindromes(string text)
    {
        palindromes = new SortedSet<string>();
        string[] words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if(IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        return palindromes;
    }

    public static bool IsPalindrome(string word)
    {
        length = word.Length;
        int middleLength = length / 2;
        int last = word.Length - 1;

        if(length == 1)
        {
            return true;
        }

        for (int i = 0; i <= middleLength; i++)
        {
            if(word[i] != word[last - i])
            {
                return false;
            }
        }

        return true;
    }

    public static void PrintPalindromes(SortedSet<string> palindromes)
    {
        length = palindromes.Count - 1;
        string result = null;

        foreach (var palindrome in palindromes)
        {
            result += palindrome + ", ";
        }

        result = result.TrimEnd(separator);

        Console.WriteLine(result);
    }
}