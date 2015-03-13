/*
 * Problem 16.	Decimal to Hexadecimal Number
 * Using loops write a program that converts an integer number to its hexadecimal representation. 
 * The input is entered as long.
 * The output should be a variable of type string. 
 * Do not use the built-in .NET functionality.
 * Examples:
 * 
 * decimal	    hexadecimal
 * 254	        FE
 * 6883	        1AE3
 * 338583669684	4ED528CBB4
 */
using System;

class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter Integer Number: ");
        long number = long.Parse(Console.ReadLine());
        long whole = 0;
        long remainder = 0;
        string reversedHex = "";
        string hex = "";

        while (number != 0)
        {
            whole = number / 16;
            remainder = number % 16;
            number = whole;

            if(remainder > -1 && remainder < 10)
            {
                reversedHex += remainder;
            }
            else
            {
                switch (remainder)
                {
                    case 10:
                        reversedHex += "A";
                        break;
                    case 11:
                        reversedHex += "B";
                        break;
                    case 12:
                        reversedHex += "C";
                        break;
                    case 13:
                        reversedHex += "D";
                        break;
                    case 14:
                        reversedHex += "E";
                        break;
                    case 15:
                        reversedHex += "F";
                        break;
                }
            }
        }

        int length = reversedHex.Length;

        for (int i = length - 1; i >= 0; i--)
        {
            hex += reversedHex[i];
        }

        Console.WriteLine("Result: " + hex);
    }
}