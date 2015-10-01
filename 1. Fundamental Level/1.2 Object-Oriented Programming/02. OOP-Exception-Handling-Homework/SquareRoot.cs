/*
 * Problem 1.	Square Root
  * Write a program that reads an integer number and calculates and prints its square root. 
  * If the number is invalid or negative, print "Invalid number".
  * In all cases finally print "Good bye". 
  * Use try-catch-finally.
 */

using System;

namespace SquareRoot
{
    internal class SquareRoot
    {
        private static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter number: ");
                var number = double.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new Exception("Invalid number!");
                }

                var sqrt = Math.Sqrt(number);

                Console.WriteLine(sqrt);
            }
            catch
            {
                Console.Error.WriteLine("Ivalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}