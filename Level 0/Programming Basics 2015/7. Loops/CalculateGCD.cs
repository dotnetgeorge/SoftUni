/*
 * Problem 17.	* Calculate GCD
 * Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
 * Use the Euclidean algorithm (find it in Internet). 
 * Examples:
 * 
 * a	b	GCD(a, b)
 * 3	2	1
 * 60	40	20
 * 5	-15	5
 */
using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int temp = 0;

        while (secondNumber != 0)
        {
            temp = secondNumber;
            secondNumber = firstNumber % secondNumber;
            firstNumber = temp;
        }

        Console.WriteLine("GCD = " + firstNumber);
    }
}