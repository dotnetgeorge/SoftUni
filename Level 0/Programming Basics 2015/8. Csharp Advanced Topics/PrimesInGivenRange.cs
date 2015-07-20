/*
 * Problem 3.	Primes in Given Range
 * Write a method that calculates all prime numbers in given range and returns them as list of integers:
 * static List<int> FindPrimesInRange(startNum, endNum)
 * {
 *      …
 * }
 * Write a method to print a list of integers. Write a program that enters two integer numbers (each at a separate line) and prints all primes in their range, separated by a comma.
 */
using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    public static List<int> primesInRange;

    static void Main(string[] args)
    {
        Console.Write("Start: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("End: ");
        int end = int.Parse(Console.ReadLine());

        primesInRange = FindPrimesInRange(start, end);

        PrintPrimes(primesInRange);
    }

    public static List<int> FindPrimesInRange(int start, int end)
    {
        primesInRange = new List<int>();
        bool check = false;

        for (int i = start; i <= end; i++)
        {
            check = IsPrime(i) && i >= 2;

            if(check)
            {
                primesInRange.Add(i);
            }
        }

        return primesInRange;
    }

    public static bool IsPrime(int number)
    {
        int loop = (int)Math.Sqrt(number);
        int count = 2;

        while (loop >= count)
        {
            if(number % count == 0)
            {
                return false;
            }

            count++;
        }

        return true;
    }

    public static void PrintPrimes(List<int> primesInRange)
    {
        foreach (var prime in primesInRange)
        {
            Console.Write(prime + " ");
        }
        Console.WriteLine();
    }
}