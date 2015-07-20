/*
 * Problem 1.	Fill the Matrix
 * Write two programs that fill and print a matrix of size N x N.
 * Filling a matrix in the regular pattern (top to bottom and left to right) is boring. 
 * Fill the matrix as described in both patterns below:
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class FillTheMatrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of cols: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = FillMatrixByFirstPattern(rows, cols);


        PrintMatrix(matrix);
        Console.WriteLine();

        matrix = FillMatrixBySecondPattern(rows, cols);
        PrintMatrix(matrix);
    }

    public static int[,] FillMatrixByFirstPattern(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        int add = 0;

        for (int row = 0; row < rows; row++)
        {
            add = row + 1;
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = add;
                add += 4;
            }
        }

        return matrix;
    }

    public static int[,] FillMatrixBySecondPattern(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];
        int add = 1;
        int count = 0;

        for (int col = 0; col < cols; col++)
        {
            count = col + 1;

            if(count % 2 != 0)
            {
                for (int row = 0; row < rows; row++)
                {
                    matrix[row, col] = add;
                    add++;
                }
            }
            else
            {
                for (int row = rows - 1; row >= 0; row--)
                {
                    matrix[row, col] = add;
                    add++;
                }
            }
        }

        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row,col] + " ");
            }
            Console.WriteLine();
        }
    }
}