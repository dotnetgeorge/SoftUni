/*
 * Problem 15.	Extract URLs from Text
 * Write a program that extracts and prints all URLs from given text. URL can be in only two formats:
 *   •	http://something, e.g. http://softuni.bg, http://forums.softuni.bg, http://www.nakov.com 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ExtractURLsFromText
{
    public static HashSet<string> extractedUrls;
    static void Main(string[] args)
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        extractedUrls = ExtractUrls(text);

        PrintUrls(extractedUrls);
    }

    public static HashSet<string> ExtractUrls(string text)
    {
        extractedUrls = new HashSet<string>();
        Regex pattern = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        MatchCollection urls = pattern.Matches(text);

        foreach (Match url in urls)
        {
            extractedUrls.Add(url.Value);
        }

        return extractedUrls;
    }

    public static void PrintUrls(HashSet<string> extractedUrls)
    {
        foreach (var url in extractedUrls)
        {
            Console.WriteLine(url);
        }
    }
}