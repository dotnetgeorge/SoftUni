/*
 * Problem 3.	Min, Max, Sum and Average of N Numbers
 * Write a program that reads from the console a sequence of n integer numbers and returns the minimal, 
 * the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
 * The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
 * The output is like in the examples below.
 * Examples:
 * 
 * input	output
 * 3        min = 1
 * 2        max = 5
 * 5        sum = 8
 * 1	    avg = 2.67   
 */
using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter Count of Numbers: ");
        int length = int.Parse(Console.ReadLine());

        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int sum = 0;
        int number = 0;

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}] Enter Number: ", (i + 1));
            number = int.Parse(Console.ReadLine());
            sum += number;

            if(number > maxValue)
            {
                maxValue = number;
            }

            if(number < minValue)
            {
                minValue = number;
            }
        }

        double average = (double)sum / length;

        Console.WriteLine("Min = " + minValue);
        Console.WriteLine("Max = " + maxValue);
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("Avg = {0:F2}", average);
    }
}