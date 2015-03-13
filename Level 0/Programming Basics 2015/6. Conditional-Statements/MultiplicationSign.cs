/*
 * Problem 4.	Multiplication Sign
 * Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 * Use a sequence of if operators. 
 * Examples:
 * a	b	    c	    result
 * 5	2	    2	    +
 * -2	-2	    1	    +
 * -2	4	    3	    -
 * 0	-2.5	4	    0
 * -1	-0.5	-5.1	-
 */
using System;

class MultiplicationSign
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        float firstNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        float product = firstNumber * secondNumber * thirdNumber;

        Console.WriteLine("a\tb\tc\tresult");

        if(product > 0)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t+", firstNumber, secondNumber, thirdNumber);
        }
        else if(product < 0)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t-", firstNumber, secondNumber, thirdNumber);
        }
        else
        {
            Console.WriteLine("{0}\t{1}\t{2}\t0", firstNumber, secondNumber, thirdNumber);
        }
    }
}