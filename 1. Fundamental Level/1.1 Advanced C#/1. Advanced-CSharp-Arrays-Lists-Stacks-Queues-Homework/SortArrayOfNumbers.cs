/*
 * Problem 1.	Sort Array of Numbers
 * Write a program to read an array of numbers from the console, sort them and print them back on the console.
 * The numbers should be entered from the console on a single line, separated by a space. 
 * Examples:
 * 
 * Input	            Output
 * 6 5 4 10 -3 120 4	-3 4 4 5 6 10 120
 * 10 9 8	            8 9 10
 */
using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string readNumbers = Console.ReadLine();
        
        char[] separator = new char[] { ' ' };
        List<int> numbers = readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
        numbers.Sort();

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}