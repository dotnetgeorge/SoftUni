/*
 * Problem 7.	Phonebook
 * Write a program that receives some info from the console about people and their phone numbers.
 * You are free to choose the manner in which the data is entered; 
 * each entry should have just one name and one number (both of them strings). 
 * After filling this simple phonebook, upon receiving the command "search", 
 * your program should be able to perform a search of a contact by name 
 * and print her details in format "{name} -> {number}". 
 * In case the contact isn't found, print "Contact {name} does not exist." 
 */
using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    public static string readLine = null;

    static void Main(string[] args)
    {
        Dictionary<string, List<string>> phoneBook = new Dictionary<string, List<string>>();

        FillDictionary(ref phoneBook);

        Search(phoneBook);
    }

    public static void FillDictionary(ref Dictionary<string, List<string>> phoneBook)
    {
        List<string> numbers = new List<string>();
        char[] separator = new char[] { '-' };
        string[] split = new string[2];
        readLine = null;
        string name = null;
        string number = null;

        while (true)
        {
            readLine = Console.ReadLine();

            if (readLine.Equals("search"))
            {
                break;
            }

            split = readLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            name = split[0];
            number = split[1];

            if (phoneBook.ContainsKey(name))
            {

                phoneBook[name].Add(number);
            }
            else
            {
                numbers = new List<string>();
                numbers.Add(number);
                phoneBook.Add(name, numbers);
            }
        }
    }

    public static void Search(Dictionary<string, List<string>> phoneBook)
    {
        string name = "1";
        int length = 0;

        Console.WriteLine("Enter name to search in phonebook.");
        while (true)
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            if(name == "end" || name == "exit")
            {
                break;
            }

            if (phoneBook.ContainsKey(name))
            {
                length = name.Length + 4;

                Console.Write(name + " -> ");

                foreach (var number in phoneBook[name])
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", name);
            }
        }
    }
}