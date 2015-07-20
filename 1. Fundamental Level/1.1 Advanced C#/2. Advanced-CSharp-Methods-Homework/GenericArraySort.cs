/*
 * Problem 7.	* Generic Array Sort
 * Write a method which takes an array of any type and sorts it. 
 * Use bubble sort or selection sort (your own implementation). 
 * You may re-use your code from a previous homework and modify it. 
 * Use a generic method (read in Internet about generic methods in C#). 
 * Make sure that what you're trying to sort can be sorted – your method should work with numbers, 
 * strings, dates, etc.,but not necessarily with custom classes like Student.
 */
using System;
using System.Collections;
using System.Collections.Generic;

class GenericArraySort
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates = 
        {
            new DateTime(2002, 3, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2014, 1, 1)
        };

        SortArray(numbers);
        SortArray(strings);
        SortArray(dates);

        PrintSortedArray(numbers);
        PrintSortedArray(strings);
        PrintSortedArray(dates);
    }

    public static void SortArray<T>(T[] elements)
    {
        int length = elements.Length;
        int min = -1;

        for (int i = 0; i < length; i++)
        {
            min = i;

            for (int j = i + 1; j < length; j++)
            {
                if(IsLess(elements[j], elements[min]))
                {
                    min = j;
                }

                T swap = elements[i];
                elements[i] = elements[min];
                elements[min] = swap;
            }
        }
    }

    public static bool IsLess(object firstElement, object secondElement)
    {
        return (firstElement.ToString().CompareTo(secondElement.ToString()) < 0);
    }

    public static T[] SwapElements<T>(T[] elements, int firstIndex, int secondIndex)
    {
        T swap = elements[firstIndex];
        elements[firstIndex] = elements[secondIndex];
        elements[firstIndex] = swap;

        return elements;
    }

    public static void PrintSortedArray<T>(T[] elements)
    {
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}