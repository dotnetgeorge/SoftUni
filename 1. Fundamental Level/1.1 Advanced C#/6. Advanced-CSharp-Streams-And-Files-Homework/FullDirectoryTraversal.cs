/*
Problem 8.	* Full Directory Traversal
Modify your previous program to recursively traverse the sub-directories of the starting directory as well.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class FullDirectoryTraversal
{
    public static Dictionary<DirectoryInfo, FileInfo[]> files;
    public static byte[] buffer;

    //public static FileInfo[] files = new FileInfo[0];
    static void Main(string[] args)
    {
        Console.Write("Enter path to directory: ");
        string directory = Console.ReadLine();

        Console.Write("Enter extension to search: ");
        string extension = Console.ReadLine();

        files = GetFiles(directory, extension);

        WriteToFile(files);

        PrintFiles(files);
    }

    public static Dictionary<DirectoryInfo, FileInfo[]> GetFiles(string directory, string extension)
    {
        try
        {
            files = new Dictionary<DirectoryInfo, FileInfo[]>();
            DirectoryInfo dir = new DirectoryInfo(directory);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] filesInDir = dir.GetFiles(extension, SearchOption.AllDirectories);

            foreach (DirectoryInfo dirInDir in dirs)
            {
                filesInDir = dirInDir.GetFiles(extension);

                files.Add(dirInDir, filesInDir);
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }

        return files;
    }

    public static async void WriteToFile(Dictionary<DirectoryInfo, FileInfo[]> files)
    {
        try
        {
            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var fileName = Path.Combine(desktop, "reports.txt");
            var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            string writeDir;
            string writeFile;

            using (fileStream)
            {
                foreach (var dir in files)
                {
                    writeDir = "--" + dir.Key + "\n";
                    buffer = GetBytes(writeDir);

                    await fileStream.WriteAsync(buffer, 0, buffer.Length);

                    foreach (var file in dir.Value)
                    {
                        writeFile = "----" + file.Name + " - " + file.Length + "\n";
                        buffer = GetBytes(writeFile);

                        await fileStream.WriteAsync(buffer, 0, buffer.Length);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }

    public static byte[] GetBytes(string line)
    {
        buffer = new byte[line.Length * sizeof(char)];
        Buffer.BlockCopy(line.ToCharArray(), 0, buffer, 0, buffer.Length);

        return buffer;
    }

    public static void PrintFiles(Dictionary<DirectoryInfo, FileInfo[]> files)
    {
        foreach (var dir in files)
        {
            Console.WriteLine("--{0}", dir.Key);

            foreach (var file in dir.Value)
            {
                Console.WriteLine("----{0} - {1}", file.Name, file.Length);
            }
        }
    }
}