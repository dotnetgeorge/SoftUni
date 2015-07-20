/*
 * Problem 2.	Last Digit of Number
 * Write a method that returns the last digit of a given integer as an English word. 
 * Test the method with different input values. 
 * Ensure you name the method properly.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class LastDigitOfNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(GetLastDigitAsWord(number));
    }

    public static string GetLastDigitAsWord(int number)
    {
        int digit = number % 10;
        string nameOfDigit = null;

        switch (digit)
        {
            case 0:
                nameOfDigit = "zero";
                break;
            case 1:
                nameOfDigit ="one";
                break;
            case 2:
                nameOfDigit = "two";
                break;
            case 3:
                nameOfDigit = "three";
                break;
            case 4:
                nameOfDigit = "four";
                break;
            case 5:
                nameOfDigit = "five";
                break;
            case 6:
                nameOfDigit = "six";
                break;
            case 7:
                nameOfDigit = "seven";
                break;
            case 8:
                nameOfDigit = "eight";
                break;
            case 9:
                nameOfDigit = "nine";
                break;
            default:
                break;
        }

        return nameOfDigit;
    }
}