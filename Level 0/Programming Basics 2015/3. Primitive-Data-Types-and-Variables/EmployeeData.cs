﻿/*
 * Problem 10.	Employee Data
 * A marketing company wants to keep record of its employees. Each record would have the following characteristics:
 * •	First name
 * •	Last name
 * •	Age (0...100)
 * •	Gender (m or f)
 * •	Personal ID number (e.g. 8306112507)
 * •	Unique employee number (27560000…27569999)
 * Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
 * Use descriptive names. 
 * Print the data at the console.
 */
using System;

class EmployeeData
{
    static void Main(string[] args)
    {
        string firstName = "John";
        string lastName = "Johnson";
        byte age = 20;
        char gender = 'm';
        long personID = 8306112507;
        int employeeNumber = 27569999;

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Person ID Number: " + personID);
        Console.WriteLine("Unique Employee Number: " + employeeNumber);
    }
}