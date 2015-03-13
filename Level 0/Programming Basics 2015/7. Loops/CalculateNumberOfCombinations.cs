/*
 * Problem 7.	Calculate N! / (K! * (N-K)!)
 * In combinatorics, the number of ways to choose k different members out of a group of n different elements 
 * (also known as the number of combinations) is calculated by the following formula:
 * N! / (K! * (N-K)!)
 * For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. 
 * Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
 * Try to use only two loops. 
 * Examples:
 * 
 * n	k	n! / (k! * (n-k)!)
 * 3	2	3
 * 4	2	6
 * 10 	6	210
 * 52	5	2598960
 */
using System;
using System.Numerics;

class CalculateNumberOfCombinations
{
    static void Main(string[] args)
    {
        int numberN = 0;
        int numberK = 0;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;

        do
        {
            Console.WriteLine("Number N Must Be Between [1 < Number N < 100]");
            Console.Write("Enter Number N: ");
            numberN = int.Parse(Console.ReadLine());
        } while (1 >= numberN || numberN >= 100);

        do
        {
            Console.WriteLine("Number K Must Be Between [1 < Number K < Number N < 100]");
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

            if((numberN - numberK) >= i)
            {
                factorialNK *= i;
            }
        }

        BigInteger result = factorialN / (factorialK * factorialNK);

        Console.WriteLine("n\tk\tn! / (k! * (n-k)!)");
        Console.WriteLine("{0}\t{1}\t{2}", numberN, numberK, result);
    }
}