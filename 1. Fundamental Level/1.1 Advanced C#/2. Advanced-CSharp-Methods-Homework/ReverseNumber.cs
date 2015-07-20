/*
 * Problem 5.	Reverse Number
 * Write a method that reverses the digits of a given floating-point number
 */
using System;
using System.Collections.Generic;
using System.Linq;

class ReverseNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter number with float point: ");
        double number = double.Parse(Console.ReadLine());

        double reversedNumber = GetReservedNumber(number);
        Console.WriteLine(reversedNumber);
    }

    public static double GetReservedNumber(double number)
    {
        string original = number.ToString();
        string reversed = null;
        int length = original.Length;

        for (int i = 0; i < length; i++)
        {
            reversed += original[length - i - 1];
        }

        double reversedNumber = Convert.ToDouble(reversed);

        return reversedNumber;
    }
}