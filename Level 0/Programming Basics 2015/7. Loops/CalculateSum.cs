/*
 * Problem 5.	Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
 * Write a program that, for a given two integer numbers n and x, calculates the sum 
 * S = 1 + 1!/x + 2!/x2 + … + n!/xn.
 * Use only one loop.
 * Print the result with 5 digits after the decimal point.
 * 
 * n	x	S
 * 3	2	2.75000
 * 4	3	2.07407
 * 5	-4	0.75781
 */
using System;

class CalculateSum
{
    static void Main(string[] args)
    {
        Console.Write("Enter N Number: ");
        int numberN = int.Parse(Console.ReadLine());

        Console.Write("Enter X Number: ");
        int numberX = int.Parse(Console.ReadLine());

        double factorial = 1d;
        double power = 1;
        double sum = 1;

        for (int i = 1; i <= numberN; i++)
        {
            factorial *= i;
            power *= numberX;
            sum += (factorial / power);
        }

        Console.WriteLine("n\tx\tS");
        Console.WriteLine("{0}\t{1}\t{2:F5}", numberN, numberX, sum);
    }
}