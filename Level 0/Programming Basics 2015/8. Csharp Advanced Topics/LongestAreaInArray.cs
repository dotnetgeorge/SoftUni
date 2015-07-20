/*
 * Problem 6.	Longest Area in Array
 * Write a program to find the longest area of equal elements in array of strings. 
 * You first should read an integer n and n strings (each at a separate line), 
 * then find and print the longest sequence of equal elements (first its length, then its elements). 
 * If multiple sequences have the same maximal length, print the leftmost of them. 
 */
using System;

class LongestAreaInArray
{
    public static string[] array;
    public static string[] longestArea;
    public static int length;

    static void Main(string[] args)
    {
        Console.Write("Enter length of array: ");
        length = int.Parse(Console.ReadLine());

        array = FillArray(length);
        longestArea = FindLongestArea(array);

        PrintResult(longestArea);
    }

    public static string[] FillArray(int length)
    {
        array = new string[length];

        for (int i = 0; i < length; i++)
        {
            array[i] = Console.ReadLine();
        }

        return array;
    }

    public static string[] FindLongestArea(string[] array)
    {
        length = array.Length;
        int count = 1, bestCount = -1;
        string bestWord = null;

        for (int i = 0; i < length - 1; i++)
        {
            if(array[i] == array[i + 1])
            {
                count++;

                if(count > bestCount)
                {
                    bestCount = count;
                    bestWord = array[i];
                }
            }
            else
            {

                count = 1;
            }
        }

        if(bestCount == -1)
        {
            bestCount = 1;
            bestWord = array[0];
        }

        longestArea = new string[bestCount];

        for (int i = 0; i < bestCount; i++)
        {
            longestArea[i] = bestWord;
        }

        return longestArea;
    }

    public static void PrintResult(string[] longestArea)
    {
        length = longestArea.Length;

        Console.WriteLine(length);
        foreach (var item in longestArea)
        {
            Console.WriteLine(item);
        }
    }
}