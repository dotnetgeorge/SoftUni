﻿/*
 * Problem 2.	Float or Double?
 * Which of the following values can be assigned to a variable of type
 * float and which to a variable of type double:
 * 34.567839023, 12.345, 8923.1234857, 3456.091?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */
using System;

class FloatOrDouble
{
    static void Main(string[] args)
    {
        float first = 12.345f;
        double second = 34.567839023;
        float third = 3456.091f;
        double fourth = 8923.1234857;

        Console.WriteLine(first);
        Console.WriteLine(second);
        Console.WriteLine(third);
        Console.WriteLine(fourth);
    }
}