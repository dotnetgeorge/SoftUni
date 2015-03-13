/*
 * Problem 7.	Sort 3 Numbers with Nested Ifs
 * Write a program that enters 3 real numbers and prints them sorted in descending order. 
 * Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
 * Examples:
 * 
 * a	b	    c	    result
 * 5	1	    2	    5 2 1
 * -2	-2	    1	    1 -2 -2
 * -2	4	    3	    4 3 -2
 * 0	-2.5	5	    5 0 -2.5
 * -1.1	-0.5	-0.1	-0.1 -0.5 -1.1
 * 10	20	    30	    30 20 10
 * 1	1	    1	    1 1 1
 */
using System;

class Sort3NumbersWithNestedIfs
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        float firstNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("a\tb\tc\tresult");
        Console.Write("{0}\t{1}\t{2}\t", firstNumber, secondNumber, thirdNumber);

        if(firstNumber > secondNumber)
        {
            if(firstNumber > thirdNumber)
            {
                if(secondNumber > thirdNumber)
                {
                    Console.Write("{0} {1} {2}", firstNumber, secondNumber, thirdNumber);
                }
                else
                {
                    Console.Write("{0} {1} {2}", firstNumber, thirdNumber, secondNumber);
                }
            }
            else
            {
                Console.Write("{0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
        }
        else
        {
            if(secondNumber > thirdNumber)
            {
                if(thirdNumber > firstNumber)
                {
                    Console.Write("{0} {1} {2}", secondNumber, thirdNumber, firstNumber);
                }
                else
                {
                    Console.Write("{0} {1} {2}", secondNumber, firstNumber, thirdNumber);
                }
            }
            else
            {
                Console.Write("{0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }

        Console.WriteLine();
    }
}