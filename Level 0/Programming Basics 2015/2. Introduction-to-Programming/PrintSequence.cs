/*
 * Problem 9.	Print a Sequence
 * Write a program that prints the first 10 members of the sequence:
 *      2, -3, 4, -5, 6, -7, ...
 */
using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i <= 12; i++)
        {
            if(i % 2 != 0)
            {
                Console.Write("-{0}, ", i);
            }
            else if(i == 12)
            {
                Console.WriteLine("{0}", i);
            }
            else
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}