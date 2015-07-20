/*
 * Problem 5.	Longest Increasing Sequence
 * Write a program to find all increasing sequences inside an array of integers.
 * The integers are given on a single line, separated by a space.
 * Print the sequences in the order of their appearance in the input array, each at a single line. 
 * Separate the sequence elements by a space. 
 * Find also the longest increasing sequence and print it at the last line. 
 * If several sequences have the same longest length, print the left-most of them. 
 * Examples:
 * 
 * Input	            Output
 * 2 3 4 1 50 2 3 4 5	2 3 4
 *                      1 50
 *                      2 3 4 5
 *                      Longest: 2 3 4 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LongestIncreasingSequence
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string readNumbers = Console.ReadLine();

        char[] separator = new char[] { ' ' };
        List<int> numbers = readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
        PrintIncrSequences(numbers);

    }

    public static void PrintIncrSequences(List<int> numbers)
    {
        int length = numbers.Count;
        int number, nextNumber = 0, count = 1, bestCount = -1;
        string result = null, bestResult = null;

        for (int i = 0; i < length; i++)
        {
            number = numbers[i];

            if (i != length - 1)
            {
                nextNumber = numbers[i + 1];
            }

            if(number < nextNumber)
            {
                Console.Write(number + " ");
                count++;
                result += number + " ";
            }
            else
            {
                Console.WriteLine(number);
                result += number + " ";
                count++;

                if (count > bestCount)
                {
                    bestCount = count;
                    bestResult = result;
                }

                count = 1;
                result = null;
            }
        }

        Console.WriteLine("Longest: " + bestResult);
    }
}