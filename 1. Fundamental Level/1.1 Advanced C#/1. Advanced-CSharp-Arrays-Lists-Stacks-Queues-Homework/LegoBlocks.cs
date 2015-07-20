using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LegoBlocks
{
    static void Main(string[] args)
    {
        int[][] firstArray = new int[4][];
        int[][] secondArray = new int[4][];
        char[] separator = new char[] { ' ' };
        string readNumbers = null;

        for (int i = 0; i < 4; i++)
        {
            Console.Write("1 jagged array {0} collumn numbers: ", (i + 1));
            readNumbers = Console.ReadLine();

            firstArray[i] = readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
        }

        for (int i = 0; i < 4; i++)
        {
            Console.Write("2 jagged array {0} collumn numbers: ", (i + 1));
            readNumbers = Console.ReadLine();

            secondArray[i] = readNumbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
        }


    }
}