/*
 * Find online more information about ASCII (American Standard Code for Information Interchange) 
 * and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255).
 * Note that some characters have a special purpose and will not be displayed as expected. 
 * You may skip them or display them differently. 
 * You may need to use for-loops (learn in Internet how).
 */
using System;

class PrintTheASCIITable
{
    static void Main(string[] args)
    {
        for (int i = 0; i <= 255; i++)
        {
            char c = (char)i;
            string display = string.Empty;

            if (char.IsWhiteSpace(c))
            {
                display = c.ToString();
                switch (c)
                {
                    case '\t':
                        Console.WriteLine("\\t");
                        break;
                    case ' ':
                        Console.WriteLine("space");
                        break;
                    case '\n':
                        Console.WriteLine("\\n");
                        break;
                    case '\r':
                        Console.WriteLine("\\r");
                        break;
                    case '\v':
                        Console.WriteLine("\\v");
                        break;
                    case '\f':
                        Console.WriteLine("\\f");
                        break;
                    default:
                        break;
                }
            }
            else if (char.IsControl(c))
            {
                display = "control";
            }
            else
            {
                display = c.ToString();
            }
            Console.WriteLine(display);
        }
    }
}