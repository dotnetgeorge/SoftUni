/*
 * Problem 4.	Rectangles
 * Write an expression that calculates rectangle’s perimeter and area by given width and height.
 * Examples:
 * width	height	perimeter	area
 * 3	    4	    14	        12
 * 2.5	    3	    11	        7.5
 * 5	    5	    20	        25
 */
using System;

class Rectangles
{
    static void Main(string[] args)
    {
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = (2 * width) + (2 * height);
        double area = width * height;

        Console.WriteLine("width\theight\tperimeter\tarea");
        Console.WriteLine("{0}\t{1}\t{2}\t\t{3}", width, height, perimeter, area);
    }
}