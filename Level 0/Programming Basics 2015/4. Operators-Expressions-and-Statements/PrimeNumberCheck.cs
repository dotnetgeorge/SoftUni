/*
 * Problem 8.	Prime Number Check
 * Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
 * (i.e. it is divisible without remainder only to itself and 1). 
 * Examples:
 * n	Prime?
 * 1	false
 * 2	true
 * 3	true
 * 4	false
 * 9	false
 * 97	true
 * 51	false
 * -3	false
 * 0	false
 */
using System;

class PrimeNumberCheck
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int endLoop = (int)Math.Sqrt(number);
        bool result = true;
        int count = 2;

        if (number == 0 || number == 1)
        {
            result = false;
        }
        else
        {
            while (endLoop >= count)
            {
                if (number % count == 0)
                {
                    result = false;
                    break;
                }

                count++;
            }
        }

        Console.WriteLine("n\tPrime?");
        Console.WriteLine("{0}\t{1}", number, result);
    }
}