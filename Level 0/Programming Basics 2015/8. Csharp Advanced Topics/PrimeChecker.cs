/*
 * Problem 2.	Prime Checker
 * Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
 */
using System;

class PrimeChecker
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        long number = long.Parse(Console.ReadLine());

        bool isPrime = IsPrime(number);

        Console.WriteLine(isPrime);
    }

    public static bool IsPrime(long number)
    {
        long loop = (long)Math.Sqrt(number);
        long count = 2;

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
}