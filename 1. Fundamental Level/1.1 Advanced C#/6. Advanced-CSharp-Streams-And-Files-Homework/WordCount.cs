/*
 * Problem 3.	Word Count
 * Write a program that reads a list of words from the file words.txt
 * and finds how many times each of the words is contained in another file text.txt. 
 * Matching should be case-insensitive.
 * Write the results in file results.txt. 
 * Sort the words by frequency in descending order. Use StreamReader in combination with StreamWriter.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

class WordCount
{
    public static Dictionary<string, int> results;
    public static Queue<string> readWords;
    //public static List<string> readText;
    public static string line;

    static void Main(string[] args)
    {
        Console.Write("Enter path to file with words: ");
        string wordsFileName = Console.ReadLine();

        Console.Write("Enter path to file with text: ");
        string textFileName = Console.ReadLine();

        readWords = ReadWords(wordsFileName);
        string readText = ReadText(textFileName);
        results = CountWords(readWords, readText);

        PrintResults(results);

        results = SortResults(results);

        PrintResults(results);
    }

    public static Queue<string> ReadWords(string wordsFileName)
    {
        try
        {
            StreamReader reader = new StreamReader(@wordsFileName);
            readWords = new Queue<string>();

            using (reader)
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    readWords.Enqueue(line);
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

        return readWords;
    }

    public static string ReadText(string textFileName)
    {

        StringBuilder readText = new StringBuilder();
        try
        {
            StreamReader reader = new StreamReader(@textFileName);
            //readText = new List<string>();
            //readText = new Queue<string>();

            using (reader)
            {
                line = reader.ReadLine();

                while (line != null)
                {
                    readText.AppendLine(line);
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

        var text = readText.ToString().Trim(new char[] {'-', ',', '.'});

        return text;
    }

    public static Dictionary<string, int> CountWords(Queue<string> readWords, string readText)
    {
        List<string> checkedWords = new List<string>();
        results = new Dictionary<string, int>();
        //string word = null;
        int lengthOfWords = readWords.Count;
        int count = 0;

        //for (int i = 0; i < lengthOfWords; i++)
        //{
        //    word = readWords.Dequeue();

        //    if(!checkedWords.Contains(word))
        //    {
        //        count = readText.Count(x => x == word);
        //        checkedWords.Add(word);
        //    }
        //}

        foreach (var word in readWords)
        {
            if(!checkedWords.Contains(word))
            {
                count = CountWord(word, readText);

                results.Add(word, count);

                checkedWords.Add(word);
            }
        }

        checkedWords.Clear();

        return results;
    }

    public static int CountWord(string word, string text)
    {
        int index = text.IndexOf(word);
        int count = 0;

        while (index != -1)
        {
            index = text.IndexOf(word, index + 1);
            count++;
        }

        return count;
    }

    public static Dictionary<string, int> SortResults(Dictionary<string, int> results)
    {
        var sortedResults = from pair in results
                            orderby pair.Value descending
                            select pair;
        results = new Dictionary<string, int>();

        foreach (var item in sortedResults)
        {
            results.Add(item.Key, item.Value);
        }

        return results;
    }

    public static void PrintResults(Dictionary<string, int> sortedResults)
    {
        foreach (var result in sortedResults)
        {
            Console.WriteLine("{0} - {1}", result.Key, result.Value);
        }
    }
}