/*
 * Problem 3.	Larger Than Neighbours
 * Write a method that checks if the element at given position in a given array of integers 
 * is larger than its two neighbours (when such exist).
 */
using System;
using System.Collections.Generic;
using System.Linq;

class LargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.Write("Count of numbers: ");
        int length = int.Parse(Console.ReadLine());

        int[] numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}] Enter number: ", (i + 1));
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(IsBiggerThanNeighbours(numbers, i));
        }

    }

    public static bool IsBiggerThanNeighbours(int[] numbers, int index)
    {
        int lastIndex = numbers.Length - 1;

        if(index == 0)
        {
            return (numbers[index] > numbers[index + 1]);
        }

        if(index == lastIndex)
        {
            return (numbers[index] > numbers[index - 1]);
        }

        bool check = ((numbers[index] > numbers[index - 1]) && (numbers[index] > numbers[index + 1]));

        return check;
    }
}