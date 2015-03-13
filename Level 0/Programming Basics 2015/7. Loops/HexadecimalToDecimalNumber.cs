/*
 * Problem 15.	Hexadecimal to Decimal Number
 * Using loops write a program that converts a hexadecimal integer number to its decimal form. 
 * The input is entered as string. 
 * The output should be a variable of type long. 
 * Do not use the built-in .NET functionality. 
 * Examples:
 * 
 * hexadecimal	decimal
 * FE	        254
 * 1AE3	        6883
 * 4ED528CBB4	338583669684
 */
using System;

class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter Hexadecimal Number: ");
        string hex = Console.ReadLine();
        string reverseHex = "";
        int length = hex.Length;
        long numberX = 0;
        long result = 0;

        for (int i = length - 1; i >= 0; i--)
        {
            reverseHex += hex[i];
        }

        for (int i = 0; i < length; i++)
        {
            switch (reverseHex[i])
            {
                case '0':
                    numberX = 0;
                    break;
                case '1':
                    numberX = 1;
                    break;
                case '2':
                    numberX = 2;
                    break;
                case '3':
                    numberX = 3;
                    break;
                case '4':
                    numberX = 4;
                    break;
                case '5':
                    numberX = 5;
                    break;
                case '6':
                    numberX = 6;
                    break;
                case '7':
                    numberX = 7;
                    break;
                case '8':
                    numberX = 8;
                    break;
                case '9':
                    numberX = 9;
                    break;
                case 'A':
                    numberX = 10;
                    break;
                case 'B':
                    numberX = 11;
                    break;
                case 'C':
                    numberX = 12;
                    break;
                case 'D':
                    numberX = 13;
                    break;
                case 'E':
                    numberX = 14;
                    break;
                case 'F':
                    numberX = 15;
                    break;
            }

            result += numberX * (long)Math.Pow(16, i);
        }

        Console.WriteLine("result: " + result);
    }
}