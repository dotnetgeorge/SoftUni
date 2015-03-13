/*
 * Problem 11.	Random Numbers in Given Range
 * Write a program that enters 3 integers n, min and max (min ≤ max)
 * and prints n random numbers in the range [min...max]. 
 * Examples:
 * 
 * n	min 	max	    random numbers
 * 5	0	    1	    1 0 0 1 1
 * 10	10	    15	    12 14 12 15 10 12 14 13 13 11
 * 
 * Note that the above output is just an example. 
 * Due to randomness, your program most probably will produce different results.
 */
using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("Enter Count Of Number: ");
        int count = int.Parse(Console.ReadLine());

        Console.Write("Enter Min Number: ");
        int minNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Max Number: ");
        int maxNumber = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int number = 0;
        int[] numbers = new int[count];

        for (int i = 0; i < count; i++)
        {
            number = rnd.Next(minNumber, maxNumber);
            numbers[i] = number;
        }

        for (int i = 0; i < count; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }
        Console.WriteLine();
    }
}