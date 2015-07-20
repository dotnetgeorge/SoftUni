/*
 * Problem 2.	Maximal Sum
 * Write a program that reads a rectangular integer matrix of size N x M 
 * and finds in it the square 3 x 3 that has maximal sum of its elements. 
 * On the first line, you will receive the rows N and columns M. 
 * On the next N lines you will receive each row with its columns.
 * Print the elements of the 3 x 3 square as a matrix, along with their sum.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    public static int[,] matrix = new int[0, 0];
    public static char[] separator = new char[] { ' ' };
    public static int rows = 0;
    public static int cols = 0;
    public static int row = 0;
    public static int col = 0;

    static void Main(string[] args)
    {
        Console.Write("Enter number of rows and cols: ");
        string readRowsAndCols = Console.ReadLine();

        int[] lengths = readRowsAndCols.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();

        rows = lengths[0];
        cols = lengths[1];

        matrix = ReadMatrixFromConsole(rows, cols);

        PrintMatrix(matrix);

        FindMaximalSum(matrix);
    }

    public static int[,] ReadMatrixFromConsole(int rows, int cols)
    {
        matrix = new int[rows, cols];
        
        List<int> numbersFromLine = new List<int>();
        string readNumbers = null;

        Console.WriteLine("Enter numbers to fill matrix.");

        for (int i = 0; i < rows; i++)
        {
            Console.Write("[{0}] Row: ", (i + 1));
            readNumbers = Console.ReadLine();

            numbersFromLine.AddRange(readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList());
        }

        Queue<int> allNumbers = new Queue<int>(numbersFromLine);

        matrix = FillMatrix(allNumbers, rows, cols);

        return matrix;
    }

    private static int[,] FillMatrix(Queue<int> numbers, int rows, int cols)
    {
        matrix = new int[rows, cols];

        for (row = 0; row < rows; row++)
        {
            for (col = 0; col < cols; col++)
            {
                matrix[row, col] = numbers.Dequeue();
            }
        }

        return matrix;
    }

    public static void FindMaximalSum(int[,] matrix)
    {
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(0);
        int sum = 0;
        int bestSum = -1;
        int bestRow = -1, bestCol = -1;

        for (row = 0; row < rows - 2; row++)
        {
            for (col = 0; col < cols - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 2, col] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if(sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("Sum = " + bestSum);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);

        for (row = 0; row < rows; row++)
        {
            for (col = 0; col < cols; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}