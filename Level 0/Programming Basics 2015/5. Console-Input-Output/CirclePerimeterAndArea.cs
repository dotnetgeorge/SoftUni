﻿/*
 * Problem 3.	Circle Perimeter and Area
 * Write a program that reads the radius r of a circle and prints its perimeter
 * and area formatted with 2 digits after the decimal point. 
 * Examples:
 * r	perimeter	area
 * 2	12.57	12.57
 * 3.5	21.99	38.48
 */
using System;

class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter Radius: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = (2 * Math.PI * radius);
        double area = Math.PI * (radius * radius);

        Console.WriteLine("r\tperimeter\tarea");
        Console.WriteLine("{0} \t {1:F2} \t {2:F2}", radius, perimeter, area);
    }
}