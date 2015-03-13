/*
 * Problem 5.	Third Digit is 7?
 * Write an expression that checks for given integer if its third digit from right-to-left is 7. 
 * Examples:
 * n	Third digit 7?
 * 5	false
 * 701	true
 * 9703	true
 * 877	false
 * 777877	false
 * 9999799	true
 */
using System;

class ThirdDigitIs7
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool result = true;

        Console.WriteLine("n\tThird digit 7?");

        if((number / 100) % 10 == 7)
        {
            Console.WriteLine("{0}\t{1}", number, result);
        }
        else
        {
            result = false;
            Console.WriteLine("{0}\t{1}", number, result);
        }
    }
}