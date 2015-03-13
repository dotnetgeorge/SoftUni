/*
 * Problem 14.	Decimal to Binary Number
 * Using loops write a program that converts an integer number to its binary representation. 
 * The input is entered as long. 
 * The output should be a variable of type string. 
 * Do not use the built-in .NET functionality. 
 * Examples:
 * 
 * decimal	    binary
 * 0	        0
 * 3	        11
 * 43691	    1010101010101011
 * 236476736	1110000110000101100101000000
 */
using System;

class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter Integer Number: ");
        long number = long.Parse(Console.ReadLine());
        long divided = 0;
        long remainder = 0;
        string reversedBinary = "";
        string binary = "";

        while (number != 0)
        {
            divided = number / 2;
            remainder = number % 2;
            number = divided;

            if(remainder == 1)
            {
                reversedBinary += "1";
            }
            else
            {
                reversedBinary += "0";
            }
        }

        int length = reversedBinary.Length;

        for (int i = length - 1; i >= 0; i--)
        {
            binary += reversedBinary[i];
        }

        Console.WriteLine("decimal\tbinary");
        Console.WriteLine("{0}", binary);
    }
}