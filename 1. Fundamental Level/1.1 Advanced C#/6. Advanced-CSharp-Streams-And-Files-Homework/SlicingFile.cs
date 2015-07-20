/*
 * Problem 5.	Slicing File
 * Write a program that takes any file and slices it to n parts. Write the following methods:
 *      •	Slice(string sourceFile, string destinationDirectory, int parts) 
 *          - slices the given source file into n parts and saves them in destinationDirectory.

 *      •	Assemble(List<string> files, string destinationDirectory)
 *          - combines all files into one, in the order they are passed, and saves the result in destinationDirectory.
 * Use FileStreams.
 * You are not allowed to use the File class or similar helper classes.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


class SlicingFile
{
    public static List<string> files;
    public static FileStream fileRead;
    public static FileStream fileWrite;
    public static byte[] buffer;
    public static string extension;
    public static int bytesRead;

    static void Main(string[] args)
    {
        Console.Write("Enter directory of file: ");
        string destinationDirectory = Console.ReadLine();

        Console.Write("Enter name of file: ");
        string sourceFile = Console.ReadLine();

        Console.Write("Enter how many parts: ");
        int parts = int.Parse(Console.ReadLine());

        files = Slice(sourceFile, destinationDirectory, parts);

        Assemble(files, destinationDirectory);
    }

    public static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
    {

        try
        {
            files = new List<string>();
            string open = destinationDirectory + "\\" + sourceFile;
            fileRead = new FileStream(open, FileMode.Open, FileAccess.Read);
            int sizeOfEachPart = (int)Math.Ceiling((double)fileRead.Length / parts);
            string baseFileName = Path.GetFileNameWithoutExtension(sourceFile);
            extension = Path.GetExtension(sourceFile);
            string fileName;
            bytesRead = 0;

            using (fileRead)
            {
                using (fileWrite)
                {
                    for (int i = 1; i <= parts; i++)
                    {
                        fileName = destinationDirectory + "\\" + baseFileName + "-" + i.ToString() + extension;
                        files.Add(fileName);

                        fileWrite = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        buffer = new byte[sizeOfEachPart];

                        if ((bytesRead = fileRead.Read(buffer, 0, sizeOfEachPart)) > 0)
                        {
                            fileWrite.Write(buffer, 0, sizeOfEachPart);
                        }
                    }
                }
            }

        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }

        return files;
    }

    public static void Assemble(List<string> files, string destinationDirectory)
    {
        try
        {
            extension = Path.GetExtension(files[0]); 
            fileWrite = new FileStream(destinationDirectory + "\\assembled" + extension, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bytesRead = 0;

            using (fileWrite)
            {
                foreach (var file in files)
                {
                    fileRead = new FileStream(file, FileMode.Open, FileAccess.Read);
                    long fileSize = fileRead.Length;

                    using (fileRead)
                    {
                        buffer = new byte[fileSize];

                        if ((bytesRead = fileRead.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileWrite.Write(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}