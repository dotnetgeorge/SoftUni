/*
 * Problem 2.	String Length
 * Write a program that reads from the console a string of maximum 20 characters. 
 * If the length of the string is less than 20, the rest of the characters should be filled with *.
 * Print the resulting string on the console.
 */
using System;
using System.Text;

class StringLength
{
    public static string result;

    static void Main(string[] args)
    {
        Console.Write("Enter something: ");
        string input = Console.ReadLine();

        result = ReturnResult(input);

        Console.WriteLine(result);
    }

    public static string ReturnResult(string input)
    {
        int length = input.Length;

        if(length < 20)
        {
            Console.WriteLine(length);
            int add = 20 - length;
            result = input.PadRight(add, '*');
            return result;
        }

        if(length == 20)
        {
            return input;
        }

        result = input.Substring(0, 20);

        return result;
    }
}