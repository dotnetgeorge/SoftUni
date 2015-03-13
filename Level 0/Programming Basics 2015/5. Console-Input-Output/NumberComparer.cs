/*
 * Problem 4.	Number Comparer
 * Write a program that gets two numbers from the console and prints the greater of them. 
 * Try to implement this without if statements. 
 * Examples:
 * a	b	greater
 * 5	6	6
 * 10	5	10
 * 0	0	0
 * -5	-2	-2
 * 1.5	1.6	1.6
 */
using System;

class NumberComparer
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        double greater = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("a\tb\tgreater");
        Console.WriteLine("{0}\t{1}\t{2}", firstNumber, secondNumber, greater);
    }
}