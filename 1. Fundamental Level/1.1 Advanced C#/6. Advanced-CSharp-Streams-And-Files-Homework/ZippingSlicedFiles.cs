/*
 * Problem 6.	Zipping Sliced Files
 * Modify your previous program to also compress the bytes while slicing parts and decompress them when assembling them back to the original file. Use GzipStream.
 * Tip: When getting files from directory, make sure you only get files with .gz extension (there might be hidden files).
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

class ZippingSlicedFiles
{
    public static FileStream fileReader;
    public static FileStream fileWriter;
    public static List<string> files;
    public static byte[] buffer;
    public static string extension;
    public static string fileName;
    public static int bytesRead = 0;

    static void Main(string[] args)
    {
        Console.Write("Enter path to directory: ");
        string destinationDirectory = Console.ReadLine();

        Console.Write("Enter name of source file: ");
        string sourceFile = Console.ReadLine();

        Console.Write("Enter number of part: ");
        int parts = int.Parse(Console.ReadLine());

        files = Slice(sourceFile, destinationDirectory, parts);
        Compress(files);
    }

    public static List<string> Slice(string sourceFile, string destinationDirectory, int parts)
    {

        try
        {
            files = new List<string>();
            string open = destinationDirectory + "\\" + sourceFile;
            string baseFileName = Path.GetFileNameWithoutExtension(sourceFile);
            extension = Path.GetExtension(sourceFile);
            fileReader = new FileStream(open, FileMode.Open, FileAccess.Read);
            int sizeOfEachPart = (int)Math.Ceiling((double)fileReader.Length / parts);

            using (fileReader)
            {
                using (fileWriter)
                {
                    for (int i = 1; i <= parts; i++)
                    {
                        fileName = destinationDirectory + "\\" + baseFileName + "-" + i + extension;
                        files.Add(fileName);

                        fileWriter = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                        buffer = new byte[sizeOfEachPart];

                        if ((bytesRead = fileReader.Read(buffer, 0, sizeOfEachPart)) > 0)
                        {
                            fileWriter.Write(buffer, 0, sizeOfEachPart);
                        }

                        string zipFileName = destinationDirectory + "\\" + baseFileName + "-" + i + ".gz";

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

    public static async void Compress(List<string> files)
    {
        try
        {
            foreach (var file in files)
            {
                fileName = file + ".gz";
                buffer = File.ReadAllBytes(file);

                using (FileStream toCompress = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (GZipStream gz = new GZipStream(toCompress, CompressionMode.Compress, false))
                    {
                        
                        await gz.WriteAsync(buffer, 0, buffer.Length);
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }

    public static void Assemble(List<string> files, string destinationDirectory)
    {

    }
}