/*
 * Problem 12.	Extract Bit from Integer
 * Write an expression that extracts from given integer n the value of given bit at index p. 
 * Examples:
 * n	    binary representation	p	bit @ p
 * 5	    00000000 00000101	    2	1
 * 0	    00000000 00000000	    9	0
 * 15   	00000000 00001111	    1	1
 * 5343	    00010100 11011111	    7	1
 * 62241	11110011 00100001	    11	0
 */
using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter Position: ");
        int position = int.Parse(Console.ReadLine());

        int bitValue = 1 << position;
        int bit = number & bitValue;

        if (bit == 0)
        {
            Console.WriteLine("{0} bit is 0\n{1}", position, Convert.ToString(number, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("{0} bit is 1\n{1}", position, Convert.ToString(number, 2).PadLeft(16, '0'));
        }
    }
}