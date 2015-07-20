/*
 * Problem 2.	Replace <a> tag
 * Write a program that replaces in a HTML document given as string all the tags <a href=…>…</a> 
 * with corresponding tags [URL href=…]…[/URL]. 
 * Print the result on the console. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class ReplaceATag
{
    public static string result;

    static void Main(string[] args)
    {
        Console.Write("Enter html: ");
        string input = Console.ReadLine();

        result = ReplaceTag(input);

        Console.WriteLine(result);
    }

    public static string ReplaceTag(string input)
    {
        Regex regex = new Regex(@"<a.*?href=(.*?)>(.*?)<\/a>", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
        MatchCollection matches = regex.Matches(input);

        string ulr = null;
        string text = null;

        foreach (Match match in matches)
        {
            ulr = match.Groups[1].ToString();
            text = match.Groups[2].ToString();
        }


        return result;
    }
}