/*
 * Problem 13.	Average Load Time Calculator
 * We have a report that holds dates, web site URLs and load times (in seconds) in the same format like in the examples below.
 * Your tasks is to calculate the average load time for each URL.
 * Print the URLs in the same order as they first appear in the input report. 
 * Print the output in the format given below.
 * Use double floating-point precision. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

class AverageLoadTimeCalculator
{
    public static Dictionary<string, List<double>> avgLoadTime;
    public static List<string> readFile;
    public static string line;

    static void Main(string[] args)
    {
        Console.Write("Enter file name of report: ");
        string fileName = Console.ReadLine();

        readFile = ReadFile(fileName);
        avgLoadTime = AvgLoadTime(readFile);
        PrintAvgTime(avgLoadTime);
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
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }

        return readFile;
    }

    public static Dictionary<string, List<double>> AvgLoadTime(List<string> readFile)
    {
        avgLoadTime = new Dictionary<string, List<double>>();
        List<string> urls = new List<string>();
        List<double> times;
        Regex regex = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        Match getUrls;
        string url = null;
        string rawTime = null;
        double time = 0.0;
        int index = 0;

        foreach (var line in readFile)
        {
            getUrls = regex.Match(line);
            url = getUrls.Value;
            index = line.LastIndexOf(" ");
            rawTime = line.Substring(index + 1).Replace('.', ',');
            time = Convert.ToDouble(rawTime);

            if(!avgLoadTime.ContainsKey(url))
            {
                times = new List<double>();
                times.Add(time);
                avgLoadTime.Add(url, times);
            }
            else
            { 
                avgLoadTime[url].Add(time);
            }
        }

        return avgLoadTime;
    }

    public static void PrintAvgTime(Dictionary<string, List<double>> avgLoadTime)
    {
        foreach (var avg in avgLoadTime)
        {
            Console.WriteLine("{0} -> {1}", avg.Key, avg.Value.Average());
        }
    }
}