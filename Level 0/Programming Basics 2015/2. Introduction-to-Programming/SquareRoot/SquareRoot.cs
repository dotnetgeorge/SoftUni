/*
 * Problem 8.	Square Root
 * Create a console application that calculates and prints the square root of the number 12345. 
 * Find in Internet “how to calculate square root in C#”.
 */
using System;

class SquareRoot
{
    static void Main(string[] args)
    {
        double number = 12345;
        double squareRoot = Math.Sqrt(number);

        Console.WriteLine("Square root of {0} is: {1} and short is: {2:F2}", number, squareRoot, squareRoot);
    }
}