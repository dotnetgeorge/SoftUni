/*
 * Problem 1.	Odd or Even Integers
 * Write an expression that checks if given integer is odd or even.
 * Examples:
 * n	Odd?
 * 3	true
 * 2	false
 * -2	false
 * -1	true
 * 0	false
 */
using System;

class OddOrEvenIntegers
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool isOdd = true;

        Console.WriteLine("n\tOdd?");

        if(number % 2 == 0)
        {
            isOdd = false;
            Console.WriteLine("{0}\t{1}", number, isOdd);
        }
        else
        {
            Console.WriteLine("{0}\t{1}", number, isOdd);
        }
    }
}