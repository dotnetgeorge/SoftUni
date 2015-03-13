/*
 * Problem 1.	Exchange If Greater
 * Write an if-statement that takes two integer variables a and b 
 * and exchanges their values if the first one is greater than the second one. 
 * As a result print the values a and b, separated by a space. 
 * Examples:
 * 
 * a	b	    result
 * 5	2	    2 5
 * 3	4	    3 4
 * 5.5	4.5	    4.5 5.5
 */
using System;

class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double temp = 0;

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("{0} {1}", secondNumber, firstNumber);
        }
    }
}