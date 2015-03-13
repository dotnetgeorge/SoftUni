/*
 * Problem 11.	Bitwise: Extract Bit #3
 * Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
 * The bits are counted from right to left, starting from bit #0. 
 * The result of the expression should be either 1 or 0. 
 * Examples:
 * n	    binary representation	bit #3
 * 5	    00000000 00000101	    0
 * 0	    00000000 00000000	    0
 * 15	    00000000 00001111	    1
 * 5343	    00010100 11011111	    1
 * 62241	11110011 00100001	    0
 */
using System;

class BitwiseExtractBit3
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        uint number = uint.Parse(Console.ReadLine());

        uint bitValue = 1 << 3;
        uint bit = number & bitValue;

        Console.WriteLine("n\tbinary representation\tbit #3");

        if(bit == 0)
        {
            Console.WriteLine("{0}\t{1}\t{2}", number, Convert.ToString(number, 2).PadLeft(16, '0'), bit);
        }
        else
        {
            Console.WriteLine("{0}\t{1}\t{2}", number, Convert.ToString(number, 2).PadLeft(16, '0'), bit);
        }
    }
}