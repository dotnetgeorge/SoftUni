/*
 * Problem 7.	Matrix of Palindromes
 * Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
 */
using System;

class MatrixOfPalindromes
{
    public static int rows;
    public static int cols;

    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of cols: ");
        cols = int.Parse(Console.ReadLine());

        string[,] matrix = new string[rows, cols];

        FillMatrix(ref matrix);

        PrintMatrix(matrix);
    }

    public static void FillMatrix(ref string[,] matrix)
    {
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = "" + (char)('a' + row) + (char)('a' + row + col) + (char)('a' + row);
            }
        }
    }

    public static void PrintMatrix(string[,] matrix)
    {
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}