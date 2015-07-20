/*
 * Problem 10.	Join Lists
 * Write a program that takes as input two lists of integers and joins them. 
 * The result should hold all numbers from the first list, and all numbers from the second list, without repeating numbers,
 * and arranged in increasing order. 
 * The input and output lists are given as integers, separated by a space, each list at a separate line. 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    public static SortedSet<int> joinedLists;

    static void Main(string[] args)
    {
        Console.Write("Enter numbers in first list: ");
        string readFirstList = Console.ReadLine();

        Console.Write("Enter numbers in second list: ");
        string readSecondList = Console.ReadLine();

        char[] separator = new char[] { ' ' };
        List<int> firstList = readFirstList.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();
        List<int> secondList = readSecondList.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();

        joinedLists = JoinListsInOne(firstList, secondList);

        PrintList(joinedLists);
    }

    public static SortedSet<int> JoinListsInOne(List<int> firstList, List<int> secondList)
    {
        joinedLists = new SortedSet<int>();

        int length = firstList.Count;
        int number; 

        for (int i = 0; i < length; i++)
        {
            number = firstList[i];
            joinedLists.Add(number);
        }

        length = secondList.Count;

        for (int i = 0; i < length; i++)
        {
            number = secondList[i];
            joinedLists.Add(number);
        }

        return joinedLists;
    }

    public static void PrintList(SortedSet<int> joinedLists)
    {
        foreach (var number in joinedLists)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}