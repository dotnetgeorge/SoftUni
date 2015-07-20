/*
 * Problem 1.	Bigger Number
 * Write a method GetMax() with two parameters that returns the larger of two integers. 
 * Write a program that reads 2 integers from the console and prints the largest of them using the method GetMax().
 */
using System;

class BiggerNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);

        Console.WriteLine("Biggest number is: " + max);
    }

    public static int GetMax(int firstNumber, int secondNumber)
    {
        return (firstNumber > secondNumber ? firstNumber : secondNumber);
    }
}