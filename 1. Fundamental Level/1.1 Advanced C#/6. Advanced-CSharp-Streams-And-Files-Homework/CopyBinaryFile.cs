/*
 * Problem 4.	Copy Binary File
 * Write a program that copies the contents of a binary file (e.g. image, video, etc.) to another using FileStream.
 * You are not allowed to use the File class or similar helper classes.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CopyBinaryFile
{
    public static FileStream file;
    public static byte[] buffer;

    static void Main(string[] args)
    {
        Console.Write("Enter path to file to copy: ");
        string fileName = Console.ReadLine();

        Console.Write("Enter path to new file: ");
        string newFile = Console.ReadLine();

        byte[] bytes = ReadFile(fileName);
        CopyTo(newFile, bytes);
    }

    public static byte[] ReadFile(string fileName)
    {
        try
        {
            file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            buffer = new byte[file.Length];

            using (file)
            {
                file.Read(buffer, 0, buffer.Length);
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }

        return buffer;
    }

    public static void CopyTo(string newFile, byte[] buffer)
    {
        try
        {
            file = new FileStream(newFile, FileMode.OpenOrCreate, FileAccess.Write);

            using (file)
            {
                file.Write(buffer, 0, buffer.Length);
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}