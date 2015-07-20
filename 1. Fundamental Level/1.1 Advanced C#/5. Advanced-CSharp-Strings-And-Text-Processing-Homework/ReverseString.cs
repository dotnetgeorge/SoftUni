/*
 * Problem 1.	Reverse String
 * Write a program that reads a string from the console, reverses it and prints the result back at the console.
 */
using System;
using System.Linq;

class ReverseString
{
    public static string reversedWord;

    static void Main(string[] args)
    {
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        reversedWord = ReverseWord(word);

        Console.WriteLine(reversedWord);
    }

    public static string ReverseWord(string word)
    {
        reversedWord = "";
        int length = word.Length;

        while (length-- > 0)
        {
            reversedWord += word[length];
        }

        return reversedWord;
    }
}