/*
 * Problem 1.	Odd Lines
 * Write a program that reads a text file and prints on the console its odd lines. 
 * Line numbers starts from 0. Use StreamReader.
 */
using System;
using System.Collections.Generic;
using System.IO;

class OddLines
{
    public static List<string> readFile;
    public static string line;

    static void Main(string[] args)
    {
        Console.Write("Enter path to file: ");
        string fileName = Console.ReadLine();

        readFile = ReadFile(fileName);

        PrintOddLines(readFile);
    }

    public static List<string> ReadFile(string fileName)
    {
        try
        {
            StreamReader reader = new StreamReader(@fileName);
            readFile = new List<string>();

            using (reader)
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    readFile.Add(line);
                    line = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException fnfe)
        {
            Console.Error.WriteLine(fnfe.Message);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }

        return readFile;
    }

    public static void PrintOddLines(List<string> readFile)
    {
        int length = readFile.Count;

        for (int i = 0; i < length; i++)
        {
            if (i % 2 == 0)
            {
                line = readFile[i];
                Console.WriteLine(line);
            }
        }
    }
}