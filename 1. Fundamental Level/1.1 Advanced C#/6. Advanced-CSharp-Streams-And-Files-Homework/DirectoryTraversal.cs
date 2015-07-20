/*
Problem 7.	Directory Traversal
Traverse a given directory for all files with the given extension. 
Search through the first level of the directory only and write information about each found file in report.txt.
The files should be grouped by their extension. Extensions should be ordered by the count of their files (from most to least). If two extensions have equal number of files, order them by name.
Files under an extension should be ordered by their size.
report.txt should be saved on the Desktop. 
Ensure the desktop path is always valid, regardless of the user.
*/
using System;
using System.IO;

class DirectoryTraversal
{
    static void Main(string[] args)
    {
        Console.Write("Enter path to directory: ");
        string directory = Console.ReadLine();

        Console.Write("Enter extension of files: ");
        string extension = Console.ReadLine();

        FileInfo[] results = FilesInDir(directory, extension);

        WriteToFile(results);

        PrintInfo(results);
    }

    public static FileInfo[] FilesInDir(string directory, string extension)
    {
        FileInfo[] info = new FileInfo[0];
        
        try
        {
            DirectoryInfo dir = new DirectoryInfo(directory);

            info = dir.GetFiles(extension, SearchOption.TopDirectoryOnly);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
        
        return info;
    }

    public static async void WriteToFile(FileInfo[] results)
    {
        try
        {
            StreamWriter writer = new StreamWriter("reports.txt");
            string write;

            var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            var fileName = Path.Combine(desktop, "reports.txt");
            var fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);

            using (fileStream)
            {
                foreach (var result in results)
                {
                    write = "--" + result.Name + " - " + result.Length.ToString() + "\n";
                    byte[] buffer = GetBytes(write);
                    await fileStream.WriteAsync(buffer, 0, buffer.Length);
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
        byte[] buffer = new byte[line.Length * sizeof(char)];
        Buffer.BlockCopy(line.ToCharArray(), 0, buffer, 0, buffer.Length);

        return buffer;
    }

    public static void PrintInfo(FileInfo[] results)
    {
        foreach (var result in results)
        {
            
            Console.WriteLine(result.Name + " - " + result.Length);
        }
    }
}