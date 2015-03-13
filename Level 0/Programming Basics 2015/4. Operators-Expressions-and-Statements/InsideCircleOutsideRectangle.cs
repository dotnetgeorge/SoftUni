/*
 * Problem 10.	Point Inside a Circle & Outside of a Rectangle
 * Write an expression that checks for given point (x, y)
 * if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
 * Examples:
 * x	y	inside K & outside of R
 * 1	2	yes
 * 2.5	2	no
 * 0	1	no
 * 2.5	1	no
 * 2	0	no
 * 4	0	no
 * 2.5	1.5	no
 * 2	1.5	yes
 */
using System;

class InsideCircleOutsideRectangle
{
    static void Main(string[] args)
    {
        Console.Write("Enter Point X: ");
        double pointX = double.Parse(Console.ReadLine());

        Console.Write("Enter Point Y: ");
        double pointY = double.Parse(Console.ReadLine());

        bool inCircle = (pointX * pointX) + (pointY * pointY) <= (1.5 * 1.5);
        bool inRectangle = (pointX <= 1) && (pointX >= -1) && (pointY <= 6) && (pointY >= 2);

        bool result = inCircle && inRectangle;

        Console.WriteLine("x\ty\tinside K & outside of R");
        Console.WriteLine("{0}\t{1}\t{2}", pointX, pointY, result);
    }
}