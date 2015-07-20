/*
 * Problem 5.	Collect the Coins
 * Working with multidimensional arrays can be (and should be) fun. 
 * Let's make a game out of it.
 * You receive the layout of a board from the console. 
 * Assume it will always have 4 rows which you'll get as strings, each on a separate line.
 * Each character in the strings will represent a cell on the board. 
 * Note that the strings may be of different length.
 * You are the player and start at he top-left corner (that would be position [0, 0] on the board). 
 * On the fifth line of input you'll receive a string with movement commands which tell you where to go next, 
 * it will contain only these four characters – '>' (move right), '<' (move left), '^' (move up) and 'v' (move down). 
 * You need to keep track of two types of events – collecting coins (represented by the symbol '$', of course) 
 * and hitting the walls of the board (when the player tries to move off the board to invalid coordinates). 
 * When all moves are over, print the amount of money collected and the number of walls hit. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class CollectTheCoins
{
    public static char[][] board = new char[4][];
    public static char[] commands = new char[0];
    public static int rowLength = 0;
    public static int colLength = 0;
    public static int length = 0;

    static void Main(string[] args)
    {
        board = FillMatrix();

        PrintBoard(board);
    }

    public static char[][] FillMatrix()
    {
        string readLine = null;
        int loop = 0;

        while (loop < 4)
        {
            readLine = Console.ReadLine();
            board[loop] = readLine.ToCharArray();
            loop++;
        }
        
        string readCommands = Console.ReadLine();
        commands = readCommands.ToCharArray();

        ExecuteCommands(board, commands);

        return board;
    }

    public static void ExecuteCommands(char[][] board, char[] commands)
    {
        rowLength = board.Length;
        length = commands.Length;

        int countSymbol = 0;
        int leftOrRight = 0;
        int upOrDown = 0;
        int wallHits = 0;

        for (int i = 0; i < length; i++)
        {
            switch (commands[i])
            {
                case 'V':
                    upOrDown += 1;

                    if(IsWall(board, upOrDown, leftOrRight))
                    {
                        wallHits++;
                        upOrDown -= 1;
                    }

                    break;
                case '>':
                    leftOrRight += 1;

                    if(IsWall(board, upOrDown, leftOrRight))
                    {
                        wallHits++;
                        leftOrRight -= 1;
                    }
                    break;
                case '<':
                    leftOrRight -= 1;

                    if(IsWall(board, upOrDown, leftOrRight))
                    {
                        wallHits++;
                        leftOrRight += 1;
                    }

                    break;
                case '^':
                    upOrDown -= 1;

                    if(IsWall(board, upOrDown, leftOrRight))
                    {
                        wallHits++;
                        upOrDown += 1;
                    }

                    break;
                default:
                    break;
            }

            if(board[upOrDown][leftOrRight] == '$')
            {
                countSymbol++;
            }
        }

        Console.WriteLine("Coins collected: " + countSymbol);
        Console.WriteLine("Wall hits: " + wallHits);
    }

    public static bool IsWall(char[][] board, int upOrDown, int leftOrRight)
    {
        if(board.Length <= upOrDown)
        {
            return true;
        }
        if(upOrDown < 0 || leftOrRight < 0)
        {
            return true;
        }
        if(board[upOrDown].Length <= leftOrRight) 
        {
            return true;
        }

        return false;
    }

    public static void PrintBoard(char[][] board)
    {
        rowLength = board.Length;

        Console.WriteLine("Printed Board!");
        for (int i = 0; i < rowLength; i++)
        {
            colLength = board[i].Length;

            for (int j = 0; j < colLength; j++)
            {
                Console.Write(board[i][j]);
            }
            Console.WriteLine();
        }
    }
}