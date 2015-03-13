/*
 * Problem 5.	The Biggest of 3 Numbers
 * Write a program that finds the biggest of three numbers. 
 * Examples:
 * 
 * a	    b	    c	    biggest
 * 5	    2	    2	    5
 * -2	    -2	    1	    1
 * -2	    4	    3	    4
 * 0	    -2.5	5	    5
 * -0.1	    -0.5	-1.1	-0.1
 */
using System;

class TheBiggestOf3Numbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        float firstNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("a\tb\tc\tbiggest");
        Console.Write("{0}\t{1}\t{2}\t", firstNumber, secondNumber, thirdNumber);

        if(firstNumber > secondNumber)
        {
            if(firstNumber > thirdNumber)
            {
                Console.Write(firstNumber);
            }
            else
            {
                Console.Write(thirdNumber);
            }
        }
        else
        {
            if(secondNumber > thirdNumber)
            {
                Console.Write(secondNumber);
            }
            else
            {
                Console.Write(thirdNumber);
            }
        }

        Console.WriteLine();
    }
}