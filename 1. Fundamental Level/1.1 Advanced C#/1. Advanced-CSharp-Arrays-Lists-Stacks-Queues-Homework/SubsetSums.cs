/*
 * Problem 6.	Subset Sums
 * Write a program that reads from the console a number N and an array of integers given on a single line.
 * Your task is to find all subsets within the array which have a sum equal to N and print them on the console 
 * (the order of printing is not important). 
 * Find only the unique subsets by filtering out repeating numbers first.
 * In case there aren't any subsets with the desired sum, print "No matching subsets." 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SubsetSums
{
    static void Main(string[] args)
    {
        Console.Write("Count of numbers: ");
        int length = int.Parse(Console.ReadLine());

        Console.Write("Enter numbers: ");
        string readNumbers = Console.ReadLine();

        int[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

        FindSubsetSum(numbers, 0, 0, length, "");
    }

    public static void FindSubsetSum(int[] numbers, int index, int current, int goal, string result)
    {
        if(numbers.Length < index || current > goal)
        {
            return;
        }

        if(numbers.Min() > goal)
        {
            Console.WriteLine("No matching subsets.");
            return;
        }

        for (int i = index; i < numbers.Length; i++)
        {
            if(current + numbers[i] == goal)
            {
                Console.WriteLine(result + "+" + numbers[i].ToString() + "=" + goal);
            }
            else if(current + numbers[i] < goal)
            {
                FindSubsetSum(numbers, i + 1, current + numbers[i], goal, result + "+" + numbers[i].ToString());
            }
        }
    }
}