/*
 * Problem 2.	Sort Array of Numbers Using Selection Sort
 * Write a program to sort an array of numbers and then print them back on the console.
 * The numbers should be entered from the console on a single line, separated by a space. 
 * Refer to the examples for problem 1.
 * Note: Do not use the built-in sorting method, you should write your own. Use the selection sort algorithm. 
 * Hint: To understand the sorting process better you may use a visual aid, e.g. Visualgo.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSort
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string readNumbers = Console.ReadLine();

        char[] separator = new char[] { ' ', ',' };
        List<int> numbers = readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();

        numbers = SelectionSortMethod(numbers);

        PrintNumbers(numbers);
    }

    public static List<int> SelectionSortMethod(List<int> numbers)
    {
        int length = numbers.Count;
        int min = 0;
        int tmp = 0;

        for (int i = 0; i < length - 1; i++)
        {
            min = i;

            for (int j = i + 1; j < length; j++)
            {
                if(numbers[j] < numbers[min])
                {
                    min = j;
                }
            }

            if(min != i)
            {
                tmp = numbers[i];
                numbers[i] = numbers[min];
                numbers[min] = tmp;
            }
        }

        return numbers;
    }

    public static void PrintNumbers(List<int> numbers)
    {
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}