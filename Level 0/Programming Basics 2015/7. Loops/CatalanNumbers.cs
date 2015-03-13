/*
 * Problem 8.	Catalan Numbers
 * In combinatorics, the Catalan numbers are calculated by the following formula:

 * Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
 * Examples:
 * 
 * n	Catalan(n)
 * 0	1
 * 5	42
 * 10	16796
 * 15	9694845
 */
using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        BigInteger factorial = 1;
        BigInteger factorialByTwo = 1;
        BigInteger factorialPlusOne = 1;
        int number = 0;

        do
        {
            Console.WriteLine("Number Must Be Between [1 < Number < 100]");
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            if(number == 0)
            {
                break;
            }
        } while (1 >= number || number >= 100);

        int length = number * 2;

        for (int i = 1; i <= length; i++)
        {
            factorialByTwo *= i;

            if((number + 1) >= i)
            {
                factorialPlusOne *= i;
            }

            if(number >= i)
            {
                factorial *= i;
            }
        }

        BigInteger catalan = factorialByTwo / (factorialPlusOne * factorial);

        Console.WriteLine("n\tCatalan(n)");
        Console.WriteLine("{0}\t{1}", number, catalan);
    }
}