/*
 * Problem 3.	Categorize Numbers and Find Min / Max / Average
 * Write a program that reads N floating-point numbers from the console. 
 * Your task is to separate them in two sets, one containing only the round numbers (e.g. 1, 1.00, etc.) 
 * and the other containing the floating-point numbers with non-zero fraction. 
 * Print both arrays along with their minimum, maximum, sum and average (rounded to two decimal places). 
 * 
 * 
 * Input	                        Output
 * 1.2 -4 5.00 12211 93.003 4 2.2	[1.2, 93.003, 2.2] -> min: 1.2, max: 93.003, sum: 96.403, avg: 32.13
 *                                  [-4, 5, 12211, 4] - > min: -4, max: 12211, sum: 12216, avg: 3054.00
 */
using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxAverage
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        string readNumbers = Console.ReadLine();

        char[] separator = new char[] { ' ' };

        //List of double numbers with floating-point
        List<double> numbersWFP = readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Double.Parse).Where(x => (x % 1 != 0)).ToList();
        //List of double numbers with floating-points and non-zero fraction
        List<double> numbersWOFP = readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Double.Parse).Where(x => (x % 1 == 0)).ToList();

        PrintNumbersWFP(numbersWFP);
        PrintNumbersWOFP(numbersWOFP);
    }

    public static void PrintNumbersWFP(List<double> numbersWFP)
    {
        double sum = numbersWFP.Sum();
        double average = numbersWFP.Average();
        double min = numbersWFP.Min();
        double max = numbersWFP.Max();
        string result = "[";
        int length = numbersWFP.Count;
        double number = 0;

        for (int i = 0; i < length; i++)
        {
            number = numbersWFP[i];

            if (i != length - 1)
            {
                result += number + ", ";
            }
            else
            {
                result += number + "]";
            }
        }

        result += String.Format(" -> min: {0}, max: {1}, sum: {2}, avg: {3:F2}", min, max, sum, average);

        Console.WriteLine(result);
    }

    public static void PrintNumbersWOFP(List<double> numbersWOFP)
    {
        double sum = numbersWOFP.Sum();
        double average = numbersWOFP.Average();
        double min = numbersWOFP.Min();
        double max = numbersWOFP.Max();
        string result = "[";
        int length = numbersWOFP.Count;
        double number = 0;

        for (int i = 0; i < length; i++)
        {
            number = numbersWOFP[i];

            if (i != length - 1)
            {
                result += String.Format("{0:F0}, ", number);
            }
            else
            {
                result += String.Format("{0:F0}]", number);
            }
        }

        result += String.Format(" -> min: {0:F0}, max: {1:F0}, sum: {2:F0}, avg: {3:F2}", min, max, sum, average);

        Console.WriteLine(result);
    }
}