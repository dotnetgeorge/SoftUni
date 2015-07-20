/*
 * Problem 4.	Sequence in Matrix
 * We are given a matrix of strings of size N x M. 
 * Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
 * Write a program that finds the longest sequence of equal strings in the matrix. 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class SequenceInMatrix
{
    public static readonly int[,] directions = { { 0, 1 }, { 1, 1 }, { -1, 1 }, { 1, 0 } };
    public static string[,] matrix = new string[0, 0];
    public static int rows = 0;
    public static int cols = 0;
    public static int row = 0;
    public static int col = 0;

    static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of cols: ");
        cols = int.Parse(Console.ReadLine());

        matrix = FillMatrix(rows, cols);

    }

    public static string[,] FillMatrix(int rows, int cols)
    {
        matrix = new string[rows, cols];
        string readWord = null;

        for (row = 0; row < rows; row++)
        {
            for (col = 0; col < cols; col++)
            {
                Console.Write("[{0},{1}] Enter string: ", row, col);
                readWord = Console.ReadLine();

                matrix[row, col] = readWord;
            }
        }

        return matrix;
    }

    public static string FindSequence(string[,] matrix)
    {
        string result = null;
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);
        
        int currentLength = 1, bestLength = 0;
        string bestElement = null;

        for (row = 0; row < rows; row++)
        {
            for (col = 0; col < cols - 1; col++)
            {
                if(matrix[row, col] == matrix[row, col + 1])
                {
                    currentLength++;

                    if(currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestElement = matrix[row, col];
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
        }

        currentLength = 1;

        for (col = 0; col < cols; col++)
        {
            for (row = 0; row < rows - 1; row++)
            {
                if(matrix[row, col] == matrix[row + 1, col])
                {
                    currentLength++;

                    if(currentLength > bestLength)
                    {
                        bestLength = currentLength;
                        bestElement = matrix[row, col];
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
        }

        return result;
    }


    public static void PrintMatrix(string[,] matrix)
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