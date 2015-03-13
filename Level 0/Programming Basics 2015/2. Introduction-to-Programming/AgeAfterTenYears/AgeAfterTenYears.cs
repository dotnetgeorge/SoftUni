/*
 * Problem 15.	* Age after 10 Years
 * Write a program to read your birthday from the console and print 
 *      how old you are now and how old you will be after 10 years.
 */
using System;

class AgeAfterTenYears
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        int afterTenYears = age + 10;

        Console.WriteLine("Your age {0} after 10 years is {1}", age, afterTenYears);
    }
}