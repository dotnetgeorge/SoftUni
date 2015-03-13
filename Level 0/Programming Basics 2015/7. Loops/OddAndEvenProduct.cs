/*
 * Problem 10.	Odd and Even Product
 * You are given n integers (given in a single line, separated by a space). 
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 
 * Examples:
 * 
 * numbers	    result
 * 2 1 1 6 3	yes
 *              product = 6
 * 3 10 4 6 5 1	yes
 *              product = 60
 * 4 3 2 5 2	no
 *              odd_product = 16
 *              even_product = 15
 */
using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        Console.Write("Enter Numbers: ");
        string numbersFromLine = Console.ReadLine();
        char[] separator = new char[] { ' ' };
        string[] separatedNumbers = numbersFromLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
        int oddProduct = 1;
        int evenProduct = 1;
        int length = separatedNumbers.Length;
        int number = 0;

        for (int i = 0; i < length; i++)
        {
            number = Convert.ToInt32(separatedNumbers[i]);

            if(i % 2 == 0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }

        if(evenProduct == oddProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + oddProduct);
            Console.WriteLine("even_product = " + evenProduct);
        }
    }
}