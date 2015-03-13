/*
 * Problem 6.	The Biggest of Five Numbers
 * Write a program that finds the biggest of five numbers by using only five if statements. 
 * Examples:
 * 
 * a	b	    c	    d	    e	    biggest
 * 5	2	    2	    4	    1	    5
 * -2	-22	    1	    0	    0	    1
 * -2	4	    3	    2	    0	    4
 * 0	-2.5	0	    5	    5	    5
 * -3	-0.5	-1.1	-2	    -0.1	-0.1
 */
using System;

class TheBiggestOfFiveNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        float firstNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        float secondNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        float thirdNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Fourth Number: ");
        float fourthNumber = float.Parse(Console.ReadLine());

        Console.Write("Enter Fifth Number: ");
        float fifthNumber = float.Parse(Console.ReadLine());

        Console.WriteLine("a\tb\tc\td\te\tbiggest");
        Console.Write("{0}\t{1}\t{2}\t{3}\t{4}\t", firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);

        if(firstNumber > secondNumber)
        {
            if(firstNumber > thirdNumber)
            {
                if(firstNumber > fourthNumber)
                {
                    if(firstNumber > fifthNumber)
                    {
                        Console.Write(firstNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
                else
                {
                    if(fourthNumber > fifthNumber)
                    {
                        Console.Write(fourthNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
            }
            else
            {
                if(thirdNumber > fourthNumber)
                {
                    if(thirdNumber > fifthNumber)
                    {
                        Console.Write(thirdNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
                else
                {
                    if(fourthNumber > fifthNumber)
                    {
                        Console.Write(fourthNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
            }
        }
        else
        {
            if(secondNumber > thirdNumber)
            {
                if (secondNumber > fourthNumber)
                {
                    if (secondNumber > fifthNumber)
                    {
                        Console.Write(secondNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
                else
                {
                    if(fourthNumber > firstNumber)
                    {
                        Console.Write(fourthNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
            }
            else
            {
                if(thirdNumber > fourthNumber)
                {
                    if(thirdNumber > fifthNumber)
                    {
                        Console.Write(thirdNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
                else
                {
                    if(fourthNumber > fifthNumber)
                    {
                        Console.Write(fourthNumber);
                    }
                    else
                    {
                        Console.Write(fifthNumber);
                    }
                }
            }
        }

        Console.WriteLine();
    }
}