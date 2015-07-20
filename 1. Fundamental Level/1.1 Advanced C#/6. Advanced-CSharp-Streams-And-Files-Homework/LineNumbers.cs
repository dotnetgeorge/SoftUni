/*
 * Problem 2.	Line Numbers
 * Write a program that reads a text file and inserts line numbers in front of each of its lines. 
 * The result should be written to another text file. 
 * Use StreamReader in combination with StreamWriter.
 */
using System;
using System.Collections.Generic;
using System.IO;

class LineNumbers
{
    public static Queue<string> readFile;
    public static Queue<string> writeLines;
    public static string line;

    static void Main(string[] args)
    {
        Console.Write("Enter path to file: ");
        string fileName = Console.ReadLine();

        readFile = ReadFile(fileName);
        writeLines = WriteLinesToFile(readFile, fileName);

        ShowFile(writeLines);
    }

    public static Queue<string> ReadFile(string fileName)
    {
        try
        {
            StreamReader reader = new StreamReader(@fileName);
            readFile = new Queue<string>();

            using (reader)
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    readFile.Enqueue(line);
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

    public static Queue<string> WriteLinesToFile(Queue<string> readFile, string fileName)
    {
        try
        {
            StreamWriter writer = new StreamWriter(fileName);
            writeLines = new Queue<string>();
            int length = readFile.Count;

            using (writer)
            {
                for (int i = 0; i < length; i++)
                {
                    line = String.Format("{0}. {1}", (i + 1), readFile.Dequeue());
                    writer.WriteLine(line);
                    writeLines.Enqueue(line);
                }
            }

        }
        catch (DriveNotFoundException dnfe)
        {
            Console.Error.WriteLine(dnfe.Message);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }

        return writeLines;
    }

    public static void ShowFile(Queue<string> writeLines)
    {
        foreach (var item in writeLines)
        {
            Console.WriteLine(item);
        }
    }
}