/*
 * Problem 10.	Fibonacci Numbers
 * Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
 * (at a single line, separated by spaces) :
 *  0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. 
 *  Note that you may need to learn how to use loops. 
 *  Examples:
 */
using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter Count of Fibonaccii Numbers: ");
        int length = int.Parse(Console.ReadLine());

        long before = 1;
        long now = 0;
        long temp = 0;

        while (length > 0)
        {
            Console.Write("{0}, ", now);

            temp = before;
            before = now;
            now = temp + before;

            length--;
        }
    }
}