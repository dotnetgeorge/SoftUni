/*
 * Problem 9.	Matrix of Numbers
 * Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20)
 * and prints a matrix like in the examples below. 
 * Use two nested loops. 
 * Examples:
 * 
 * n	matrix
 * 2	1 2
 *      2 3
 *      
 * n	matrix
 * 3	1 2 3
 *      2 3 4
 *      3 4 5
 */
using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int length = 0;

        do
        {
            Console.WriteLine("Length of Matrix Must Be Between [1 <= Length <= 20]");
            Console.Write("Enter Length: ");
            length = int.Parse(Console.ReadLine());
        } while (0 >= length || length >= 21);

        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < length; j++)
            {
                Console.Write("{0} ", (j + i + 1));
            }
            Console.WriteLine();
        }
    }
}