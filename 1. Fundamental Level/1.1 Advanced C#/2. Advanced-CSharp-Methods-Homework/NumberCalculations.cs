/*
 * Problem 6.	Number Calculations
 * Write methods to calculate the minimum, maximum, average, sum and product of a given set of numbers. 
 * Overload the methods to work with numbers of type double and decimal.
 * Note: Do not use LINQ.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class NumberCalculations
{
    static void Main(string[] args)
    {
        double[] firstSequence = new double[] { 2.35, 2.354, 54445.4456, 57.343564 };
        decimal[] secondSequence = new decimal[] { 45.35m, 45.67894m, 688.533m, 32.34654m };

        Console.WriteLine(Min(firstSequence));
        Console.WriteLine(Min(secondSequence));

        Console.WriteLine(Max(firstSequence));
        Console.WriteLine(Max(secondSequence));

        Console.WriteLine(Average(firstSequence));
        Console.WriteLine(Average(secondSequence));

        Console.WriteLine(Sum(firstSequence));
        Console.WriteLine(Sum(secondSequence));

        Console.WriteLine(Product(firstSequence));
        Console.WriteLine(Product(secondSequence));
    }


    public static T Min<T>(T[] elements)
    {
        Array.Sort(elements);

        return elements[0];
    }

    public static T Max<T>(T[] elements)
    {
        Array.Sort(elements);
        int length = elements.Length;

        return elements[length - 1];
    }

    public static T Average<T>(T[] elements)
    {
        int length = elements.Length;
        dynamic average = (dynamic)Sum(elements) / length;

        return average;
    }

    public static T Sum<T>(T[] elements)
    {
        dynamic sum = 0;

        foreach (var item in elements)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(T[] elements)
    {
        dynamic product = 1;

        foreach (var item in elements)
        {
            product *= item;
        }

        return product;
    }
}