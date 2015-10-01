using System;
using System.Collections.Generic;

namespace MinesweeperApp
{
    public class Minesweeper
    {
        private static void Main()
        {
            List<Leaderboard> winners = new List<Leaderboard>(6);
            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] bombs = PutBombs();
            bool firstFlag = true;
            bool secondFlag2 = false;
            bool isBomb = false;
            const int MAX = 35;
            int count = 0;
            int row = 0;
            int col = 0;
            
            do
            {
                if (firstFlag)
                {
                    Console.WriteLine("Let's play “Minesweeper”");
                    Console.WriteLine("List of commands");
                    Console.WriteLine("1. top - show leaderboard.");
                    Console.WriteLine("2. restart - restarting the game.");
                    Console.WriteLine("3. exit - exit the game.");
                    PrintBoard(board);
                    firstFlag = false;
                }

                Console.Write("Enter row and col: ");
                command = Console.ReadLine().Trim();

                if (command.Length > 2)
                {
                    if (int.TryParse(command[0].ToString(), out row) && int.TryParse(command[2].ToString(), out col)
                        && row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Rating(winners);
                        break;
                    case "restart":
                        board = CreateBoard();
                        bombs = PutBombs();
                        PrintBoard(board);
                        isBomb = false;
                        firstFlag = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                YourMove(board, bombs, row, col);
                                count++;
                            }

                            if (MAX == count)
                            {
                                secondFlag2 = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            isBomb = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nWRONG!!! Invalid Command\n");
                        break;
                }

                if (isBomb)
                {
                    PrintBoard(bombs);
                    Console.WriteLine("\nYou are dead. Your points are {0}", count);
                    Console.Write("Enter your username: ");
                    string userName = Console.ReadLine();

                    Leaderboard t = new Leaderboard(userName, count);

                    if (winners.Count > 4)
                    {
                        for (int i = 0; i < winners.Count; i++)
                        {
                            if (winners[i].Points < t.Points)
                            {
                                winners.Insert(i, t);
                                winners.RemoveAt(winners.Count - 1);
                                break;
                            }
                        }
                    }
                    else
                    {
                        winners.Add(t);
                    }

                    winners.Sort((Leaderboard r1, Leaderboard r2) => r2.Player.CompareTo(r1.Player));
                    winners.Sort((Leaderboard r1, Leaderboard r2) => r2.Points.CompareTo(r1.Points));
                    Rating(winners);

                    board = CreateBoard();
                    bombs = PutBombs();
                    count = 0;
                    isBomb = false;
                    firstFlag = true;
                }

                if (secondFlag2)
                {
                    Console.WriteLine("\nWIN!!!");

                    PrintBoard(bombs);

                    Console.WriteLine("Enter your username: ");
                    string userName = Console.ReadLine();

                    Leaderboard points = new Leaderboard(userName, count);

                    winners.Add(points);
                    Rating(winners);
                    board = CreateBoard();
                    bombs = PutBombs();
                    count = 0;
                    secondFlag2 = false;
                    firstFlag = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void Rating(List<Leaderboard> points)
        {
            Console.WriteLine("\nTo4KI:");

            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii", i + 1, points[i].Player, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void YourMove(char[,] board, char[,] bombs, int row, int col)
        {
            char bombsCount = BombsCount(bombs, row, col);
            bombs[row, col] = bombsCount;
            board[row, col] = bombsCount;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n\t0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("\t---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("\t---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] PutBombs()
        {
            List<int> bombsCells = new List<int>();
            Random random = new Random();
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = '-';
                }
            }
            
            while (bombsCells.Count < 15)
            {
                int randomNumber = random.Next(50);

                if (!bombsCells.Contains(randomNumber))
                {
                    bombsCells.Add(randomNumber);
                }
            }

            foreach (int bombCell in bombsCells)
            {
                int col = bombCell / cols;
                int row = bombCell % cols;

                if (row == 0 && bombCell != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                board[col, row - 1] = '*';
            }

            return board;
        }

        private static void InsertBombsCount(char[,] board)
        {
            int cols = board.GetLength(0);
            int rows = board.GetLength(1);

            for (int row = 0; row < cols; row++)
            {
                for (int col = 0; col < rows; col++)
                {
                    if (board[row, col] != '*')
                    {
                        char bombsCount = BombsCount(board, row, col);
                        board[row, col] = bombsCount;
                    }
                }
            }
        }

        private static char BombsCount(char[,] board, int row, int col)
        {
            int bombsCount = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    bombsCount++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, col] == '*')
                {
                    bombsCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if (col + 1 < cols)
            {
                if (board[row, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    bombsCount++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    bombsCount++;
                }
            }

            return char.Parse(bombsCount.ToString());
        }
    }
}