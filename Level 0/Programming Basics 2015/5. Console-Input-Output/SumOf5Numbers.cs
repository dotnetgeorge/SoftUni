/*
 * Problem 7.	Sum of 5 Numbers
 * Write a program that enters 5 numbers (given in a single line, separated by a space), 
 * calculates and prints their sum. 
 * Examples:
 * 
 * numbers	    sum
 * 1 2 3 4 5	15
 * 
 * numbers	        sum
 * 10 10 10 10 10	50
 * 
 * numbers	            sum
 * 1.5 3.14 8.2 -1 0	11.84
 */
using System;

class SumOf5Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter Numbers: ");
        string numbersFromLine = Console.ReadLine();
        char[] separator = new char[] { ' ' };
        string[] separateNumbers = numbersFromLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        double number = double.MinValue;
        double sum = 0;

        for (int i = 0; i < 5; i++)
        {
            number = Convert.ToDouble(separateNumbers[i]);
            sum += number;
        }

        Console.WriteLine("Sum = " + sum);
    }
}