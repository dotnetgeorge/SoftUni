/*
 * Problem 4.	First Larger Than Neighbours
 * Write a method that returns the index of the first element in array 
 * that is larger than its neighbours, or -1 if there's no such element.
 * Use the method from the previous exercise in order to re.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        Console.Write("Length of array: ");
        int length = int.Parse(Console.ReadLine());

        int[] numbers = new int[length];

        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}] Enter number: ", (i + 1));
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine(FirstBiggerNeighbour(numbers));
    }

    public static int FirstBiggerNeighbour(int[] numbers)
    {
        int length = numbers.Length;
        bool check = false;

        for (int i = 0; i < length; i++)
        {
            if(i == 0)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    return i;
                }
                else
                {
                    i++;
                }
            }

            if(i == length - 1)
            {
                if(numbers[i] > numbers[i - 1])
                {
                    return i;
                }
                else
                {
                    return -1;
                }
            }

            check = ((numbers[i] > numbers[i - 1]) && (numbers[i] > numbers[i + 1]));

            if(check)
            {
                return i;
            }
        }

        return -1;
    }
}