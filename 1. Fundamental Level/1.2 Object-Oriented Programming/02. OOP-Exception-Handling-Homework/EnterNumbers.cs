/*
Problem 2.	Enter Numbers
Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
If the user enters an invalid number, let the user to enter again.
*/

using System;
using System.Collections.Generic;

internal class EnterNumbers
{
    private static void Main()
    {
        Console.Write("Enter start: ");
        var start = int.Parse(Console.ReadLine());

        Console.Write("Enter end: ");
        var end = int.Parse(Console.ReadLine());

        ReadNumber(start, end);
    }

    public static void ReadNumber(int start, int end)
    {
        var numbers = new List<int>();
        int number, numberBefore = 1;

        for (var i = start; i <= end; i++)
        {
            try
            {
                number = int.Parse(Console.ReadLine());

                if (number <= 1 || number <= numberBefore)
                {
                    throw new ArgumentOutOfRangeException("Number must be bigger than " + numberBefore);
                }

                numberBefore = number;
            }
            catch
            {
                Console.WriteLine("Error");
                Console.WriteLine("Enter number again!");
                --i;
            }
        }

        numbers.Clear();
    }
}