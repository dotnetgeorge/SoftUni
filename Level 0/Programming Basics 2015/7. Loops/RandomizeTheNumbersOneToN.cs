/*
 * Problem 12.	* Randomize the Numbers 1…N
 * Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
 * Examples:
 * 
 * n	randomized numbers 1…n
 * 3	2 1 3
 * 10	3 4 8 2 6 7 9 1 10 5 
 * 
 * Note that the above output is just an example.
 * Due to randomness, your program most probably will produce different results. 
 * You might need to use arrays.
 */
using System;
using System.Collections.Generic;

class RandomizeTheNumbersOneToN
{
    static void Main(string[] args)
    {
        List<int> takenNumbers = new List<int>();
        Random rnd = new Random();
        Console.Write("Enter Length of Loop: ");
        int length = int.Parse(Console.ReadLine());
        int number = 0;

        for (int i = 0; i < length; i++)
        {
            do
            {
                number = rnd.Next(1, length + 1);
            } while (takenNumbers.Contains(number));

            Console.Write("{0} ", number);
            takenNumbers.Add(number);
        }

        Console.WriteLine();
    }
}