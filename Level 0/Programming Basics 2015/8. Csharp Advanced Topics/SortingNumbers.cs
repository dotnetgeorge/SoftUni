/*
 * Problem 5.	Sorting Numbers
 * Write a program that reads a number n and a sequence of n integers, sorts them and prints them. 
 */
using System;
using System.Collections.Generic;

class SortingNumbers
{
    public static int[] numbers;

    static void Main(string[] args)
    {
        Console.Write("Enter count of numbers: ");
        int length = int.Parse(Console.ReadLine());

        numbers = FillArray(length);

        Array.Sort(numbers);

        PrintSortedArray(numbers);
    }

    public static int[] FillArray(int length)
    {
        numbers = new int[length];
        int number;

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}] Enter number: ", (i + 1));
            number = int.Parse(Console.ReadLine());

            numbers[i] = number;
        }

        return numbers;
    }

    public static void PrintSortedArray(int[] numbers)
    {
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}