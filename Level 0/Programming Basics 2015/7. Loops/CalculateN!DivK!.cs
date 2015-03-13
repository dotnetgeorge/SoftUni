/*
 * Problem 6.	Calculate N! / K!
 * Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
 * Use only one loop. 
 * Examples:
 * 
 * n	k	n! / k!
 * 5	2	60
 * 6	5	6
 * 8	3	6720
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        int numberN = 0;
        int numberK = 0;
        long factorialN = 1;
        long factorialK = 1;

        do
        {
            Console.WriteLine("Number N must be between [1 < n < 100]");
            Console.Write("Enter Number N: ");
            numberN = int.Parse(Console.ReadLine());
        } while (1 >= numberN || numberN >= 100);

        do
        {
            Console.WriteLine("Number K must be between [1 < Number K < Number N < 100]");
            Console.Write("Enter Number K: ");
            numberK = int.Parse(Console.ReadLine());
        } while (1 >= numberK || numberK >= numberN);

        for (int i = 1; i <= numberN; i++)
        {
            factorialN *= i;

            if(numberK >= i)
            {
                factorialK *= i;
            }
        }

        long result = factorialN / factorialK;

        Console.WriteLine("n\tk\tn! / k!");
        Console.WriteLine("{0}\t{1}\t{2}", numberN, numberK, result);
    }
}