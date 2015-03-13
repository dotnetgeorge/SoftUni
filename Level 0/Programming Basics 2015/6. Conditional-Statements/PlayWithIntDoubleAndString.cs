/*
 * Problem 9.	Play with Int, Double and String
 * Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
 * If the variable is int or double, the program increases it by one.
 * If the variable is a string, the program appends "*" at the end. 
 * Print the result at the console. 
 * Use switch statement. 
 * Example:
 * 
 * program	                user
 * Please choose a type:
 * 1 --> int
 * 2 --> double
 * 3 --> string	            3
 * Please enter a string:	hello
 * hello*	
 */
using System;

class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        Console.Write("Please choose a type: ");
        int type = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                Console.Write("Please enter a int: ");
                int firstNumber = int.Parse(Console.ReadLine());
                firstNumber++;

                Console.WriteLine(firstNumber);
                break;
            case 2:
                Console.Write("Please enter a double: ");
                double secondNumber = double.Parse(Console.ReadLine());
                secondNumber++;

                Console.WriteLine(secondNumber);
                break;
            case 3:
                Console.Write("Please Enter a string: ");
                string word = Console.ReadLine();
                word += "*";

                Console.WriteLine(word);
                break;
            default:
                break;
        }
    }
}