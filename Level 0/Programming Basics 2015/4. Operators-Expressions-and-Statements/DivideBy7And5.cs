/*
 * Problem 3.	Divide by 7 and 5
 * Write a Boolean expression that checks for given integer if it can be divided 
 * (without remainder) by 7 and 5 in the same time. 
 * Examples:
 * n	Divided by 7 and 5?
 * 3	false
 * 0	false
 * 5	false
 * 7	false
 * 35	true
 * 140	true
 */
using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool result = true;

        Console.WriteLine("n\tDivided by 7 and 5?");

        if((number % 7 == 0) && (number % 5 == 0) && number != 0)
        {
            Console.WriteLine("{0}\t{1}", number, result);
        }
        else
        {
            result = false;
            Console.WriteLine("{0}\t{1}", number, result);
        }
    }
}