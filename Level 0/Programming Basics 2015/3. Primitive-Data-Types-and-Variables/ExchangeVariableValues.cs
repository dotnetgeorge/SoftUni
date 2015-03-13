/*
 * Problem 9.	Exchange Variable Values
 * Declare two integer variables a and b and assign them with 5 and 10
 * and after that exchange their values by using some programming logic.
 * Print the variable values before and after the exchange.
 */
using System;

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int firstValue = 5;
        int secondValue = 10;

        firstValue += secondValue;
        secondValue = firstValue - secondValue;
        firstValue = firstValue - secondValue;

        //int temp = firstValue;
        //firstValue = secondValue;
        //secondValue = temp;

        Console.WriteLine(firstValue);
        Console.WriteLine(secondValue);
    }
}