/*
 * Problem 3.	Matrix shuffling
 * Write a program which reads a string matrix from the console and performs certain operations with its elements.
 * User input is provided like in the problem above – first you read the dimensions and then the data. 
 * Remember, you are not required to do this step first, you may add this functionality later.  
 * Your program should then receive commands in format: "swap x1 y1 x2 y2"
 * where x1, x2, y1, y2 are coordinates in the matrix.
 * In order for a command to be valid, it should start with the "swap" keyword along with four valid coordinates (no more, no less). You should swap the values at the given coordinates (cell [x1, y1] with cell [x2, y2]) and print the matrix at each step (thus you'll be able to check if the operation was performed correctly). 
 * If the command is not valid (doesn't contain the keyword "swap",
 * has fewer or more coordinates entered or the given coordinates do not exist),
 * print "Invalid input!" and move on to the next command.
 * Your program should finish when the string "END" is entered.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class MatrixShuffling
{
    public static char[] separator = new char[] { ' ', 's', 'w', 'a', 'p' };
    public static dynamic[,] matrix = new dynamic[0, 0];
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

        matrix = ReadMatrixFromConsole(rows, cols);

        ReadCommands(matrix);
    }

    public static dynamic[,] ReadMatrixFromConsole(int rows, int cols)
    {
        Queue<dynamic> allNumbers = new Queue<dynamic>();
        int loop = rows * cols;
        dynamic number = 0;

        while (loop-- > 0)
        {
            Console.Write("Enter number: ");
            number = Console.ReadLine();

            allNumbers.Enqueue(number);
        }

        matrix = FillMatrix(allNumbers, rows, cols);

        return matrix;
    }

    private static dynamic[,] FillMatrix(Queue<dynamic> numbers, int rows, int cols)
    {
        matrix = new dynamic[rows, cols];

        for (row = 0; row < rows; row++)
        {
            for (col = 0; col < cols; col++)
            {
                matrix[row, col] = numbers.Dequeue();
            }
        }

        return matrix;
    }

    public static void ReadCommands(dynamic[,] matrix)
    {
        List<int> cmdNumbers = new List<int>();
        string command = null;
        int length = ((matrix.GetLength(0) * matrix.GetLength(1)) - 1);

        while (true)
        {
            Console.Write("Enter command: ");
            command = Console.ReadLine();

            if(command.Equals("END"))
            {
                break;
            }

            cmdNumbers = command.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToList();

            bool checkCommand = ((!command.Contains("swap")) || (cmdNumbers.Count != 4) || (cmdNumbers.Max() > length));

            if (checkCommand)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                ExecuteCommand(matrix, cmdNumbers[0], cmdNumbers[1], cmdNumbers[2], cmdNumbers[3]);
            }
        }
    }

    public static void ExecuteCommand(dynamic[,] matrix, int firstRow, int firstCol, int secondRow, int secondCol)
    {
        dynamic swap = matrix[firstRow, firstCol];
        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
        matrix[secondRow, secondCol] = swap;

        PrintMatrix(matrix);
    }

    public static void PrintMatrix(dynamic[,] matrix)
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