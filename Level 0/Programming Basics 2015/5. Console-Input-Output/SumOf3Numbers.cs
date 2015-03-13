/*
 * Problem 1.	Sum of 3 Numbers
 * Write a program that reads 3 real numbers from the console and prints their sum. 
 * Examples:
 * a	b	c	    sum
 * 3	4	11	    18
 * -2	0	3	    1
 * 5.5	4.5	20.1	30.1
 */
using System;

class SumOf3Numbers
{
    static void Main(string[] args)
    {
        Console.Write("First Number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Second Number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Third Number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("a\tb\tc\tsum");
        Console.WriteLine("{0}\t{1}\t{2}\t{3}", firstNumber, secondNumber, thirdNumber, sum);
    }
}