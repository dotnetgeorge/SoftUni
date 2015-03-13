/*
 * Problem 7.	Point in a Circle
 * Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
 * Examples:
 * x	y	inside
 * 0	1	true
 * -2	0	true
 * -1	2	false
 * 1.5	-1	true
 * -1.5	-1.5	false
 * 100	-30	false
 * 0	0	true
 * 0.2	-0.8	true
 * 0.9	-1.93	false
 * 1	1.655	true
 */
using System;

class PointInCircle
{
    static void Main(string[] args)
    {
        Console.Write("Enter X: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("Enter Y: ");
        double pointY = double.Parse(Console.ReadLine());

        bool isInCircle = (pointX * pointX) + (pointY * pointY) <= (2 * 2);

        Console.WriteLine("x\ty\tinside");

        if(isInCircle)
        {
            Console.WriteLine("{0}\t{1}\t{2}", pointX, pointY, isInCircle);
        }
        else
        {
            Console.WriteLine("{0}\t{1}\t{2}", pointX, pointY, isInCircle);
        }
    }
}