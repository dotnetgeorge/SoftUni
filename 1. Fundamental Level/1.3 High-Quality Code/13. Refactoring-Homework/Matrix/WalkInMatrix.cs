using System;

namespace Matrix
{
    class WalkInMatrix
    {
        static bool checkRow;
        static bool checkCol;
        static int rows;
        static int cols;
        static int row;
        static int col;

        static void Main()
        {
            Console.Write("Enter a positive number ");
            string input = Console.ReadLine();
            int length;

            while (!int.TryParse(input, out length) || length <= 1 || length >= 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                Console.Write("Enter a positive number ");
                input = Console.ReadLine();
            }

            Console.Clear();

            int[,] matrix = new int[length, length];
            int step = length;
            int count = 1;
            int row = 0;
            int col = 0;
            int directionX = 1;
            int directionY = 1;

            FillMatrix(ref matrix, ref row, ref col, ref count, directionX, directionY, length);

            FindCell(matrix, out row, out col);

            if(row != 0 && col != 0)
            {
                directionX = 1;
                directionY = 1;
                count++;
                FillMatrix(ref matrix, ref row, ref col, ref count, directionX, directionX, length);
            }

            PrintMatrix(matrix);
        }

        /// <summary>
        /// Fills the matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="row">The row.</param>
        /// <param name="col">The col.</param>
        /// <param name="count">The count.</param>
        /// <param name="directionX">The direction x.</param>
        /// <param name="directionY">The direction y.</param>
        /// <param name="length">The length.</param>
        static void FillMatrix(ref int[,] matrix, ref int row, ref int col, ref int count, int directionX, int directionY, int length)
        {
            matrix[row, col] = count;

            while (Check(matrix, row, col))
            {
                checkRow = (row + directionX >= length || row + directionX < 0);
                checkCol = (col + directionY >= length || col + directionY < 0);

                if (checkRow || checkCol || matrix[row + directionX, col + directionY] != 0)
                {
                    while ((row + directionX >= length || row + directionX < 0 || col + directionY >= length || col + directionY < 0 || matrix[row + directionX, col + directionY] != 0))
                    {
                        Change(ref directionX, ref directionY);
                    }
                }

                row += directionX;
                col += directionY;
                count++;
                matrix[row, col] = count;
            }
        }

        /// <summary>
        /// Checks the specified matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="positionX">The position x.</param>
        /// <param name="positionY">The position y.</param>
        /// <returns></returns>
        static bool Check(int[,] matrix, int positionX, int positionY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);

            for (int i = 0; i < 8; i++)
            {
                checkRow = ((positionX + directionsX[i] >= rows) || (positionX + directionsX[i] < 0));

                if (checkRow)
                {
                    directionsX[i] = 0;
                }

                checkCol = ((positionY + directionsY[i] >= cols) || (positionY + directionsY[i] < 0));

                if (checkCol)
                {
                    directionsY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (matrix[positionX + directionsX[i], positionY + directionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Changes the specified direction x.
        /// </summary>
        /// <param name="directionX">The direction x.</param>
        /// <param name="directionY">The direction y.</param>
        static void Change(ref int directionX, ref int directionY)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            int countDirection = 0;

            for (int count = 0; count < 8; count++)
            {
                checkRow = (directionsX[count] == directionX);
                checkCol = (directionsY[count] == directionY);

                if (checkRow && checkCol)
                {
                    countDirection = count;
                    break;
                }
            }

            if (countDirection == 7)
            {
                directionX = directionsX[0];
                directionY = directionsY[0];
                return;
            }

            directionX = directionsX[countDirection + 1];
            directionY = directionsY[countDirection + 1];
        }

        /// <summary>
        /// Finds the cell.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        /// <param name="positionX">The position x.</param>
        /// <param name="positionY">The position y.</param>
        static void FindCell(int[,] matrix, out int positionX, out int positionY)
        {
            positionX = 0;
            positionY = 0;
            rows = matrix.GetLength(0);
            cols = matrix.GetLength(1);

            for (row = 0; row < rows; row++)
            {
                for (col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        positionX = row;
                        positionY = col;
                        return;
                    }
                }
            }
        }

        /// <summary>
        /// Prints the matrix.
        /// </summary>
        /// <param name="matrix">The matrix.</param>
        static void PrintMatrix(int[,] matrix)
        {
            int length = matrix.GetLength(0);

            for (row = 0; row < length; row++)
            {
                for (col = 0; col < length; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}