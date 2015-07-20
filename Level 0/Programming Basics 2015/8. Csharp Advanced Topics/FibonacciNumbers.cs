/*
 * Problem 1.	Fibonacci Numbers
 * Define a method Fib(n) that calculates the nth Fibonacci number. 
 */
using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        BigInteger fibonacci = FibonacciNumber(number);

        Console.WriteLine("Fibonacci: " + fibonacci);
    }

    public static BigInteger FibonacciNumber(int number)
    {
        if (number == 0 || number == 1)
        {
            return number;
        }

        return FibonacciNumber(number - 1) + FibonacciNumber(number - 2);
    }
}