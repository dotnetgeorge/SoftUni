/*
 * Problem 9.	Sum of n Numbers
 * Write a program that enters a number n and after that enters more n numbers 
 * and calculates and prints their sum. 
 * Note that you may need to use a for-loop. 
 * Examples:
 * 
 * numbers	sum
 * 3
 * 20
 * 60
 * 10	    90
 */
using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter Count of Numbers: ");
        int length = int.Parse(Console.ReadLine());
        
        double sum = 0;
        double number = 0;

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}] Enter Number: ", (i + 1));
            number = double.Parse(Console.ReadLine());

            sum += number;
        }

        Console.WriteLine("Sum = " + sum);
    }
}