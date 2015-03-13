/*
 * Problem 6.	Quadratic Equation
 * Write a program that reads the coefficients a, b and c of a quadratic equation 
 * ax^2 + bx + c = 0 and solves it (prints its real roots). 
 * Examples:
 * a	b	c	roots
 * 2	5	-3	x1=-3; x2=0.5
 * -1	3	0	x1=3; x2=0
 * -0.5	4	-8	x1=x2=4
 * 5	2	8	no real roots
 */
using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        Console.Write("Enter First Number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter Second Number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Enter Third Number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double firstX = double.MinValue;
        double secondX = double.MinValue;
        double numberX = double.MinValue;
        double discriminant = double.MinValue;

        if (firstNumber == 0)
        {
            if(secondNumber == 0)
            {
                if(thirdNumber == 0)
                {
                    Console.WriteLine("Every X is solution.");
                }
                else
                {
                    Console.WriteLine("No Solution.");
                }
            }
            else
            {
                numberX = (-thirdNumber) / secondNumber;

                Console.WriteLine("X = {0:F2}", numberX);
            }
        }
        else
        {
            discriminant = (secondNumber * secondNumber) - (4 * firstNumber * thirdNumber);

            if(discriminant > 0)
            {
                firstX = ((-secondNumber) - Math.Sqrt(discriminant)) / (2 * firstNumber);
                secondX = ((-secondNumber) + Math.Sqrt(discriminant)) / (2 * firstNumber);

                Console.WriteLine("First X = {0:F2}", firstX);
                Console.WriteLine("Second X = {0:F2}", secondX);
            }
            else
            {
                if(discriminant == 0)
                {
                    numberX = (-secondNumber) / (2 * firstNumber);

                    Console.WriteLine("X = {0:F2}", numberX);
                }
                else
                {
                    Console.WriteLine("No Real Roots");
                }
            }
        }
    }
}