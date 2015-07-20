/*
 * Problem 5.	Unicode Characters
 * Write a program that converts a string to a sequence of C# Unicode character literals. 
 */
using System;
using System.Text;

class UnicodeCharacters
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        string result = ConvertToUnicode(input);

        Console.WriteLine(result);
    }

    public static string ConvertToUnicode(string input)
    {
        StringBuilder result = new StringBuilder();

        foreach (var item in input)
        {
            result.Append("\\u");
            result.AppendFormat("{0:x4}", (int)item);
        }

        return result.ToString();
    }
}