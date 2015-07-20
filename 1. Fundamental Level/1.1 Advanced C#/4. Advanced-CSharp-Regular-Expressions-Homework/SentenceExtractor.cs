/*
 * Problem 4.	Sentence Extractor
 * Write a program that reads a keyword and some text from the console and prints all sentences from the text,
 * containing that word. A sentence is any sequence of words ending with '.', '!' or '?'. 
 */
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main(string[] args)
    {
        string input = "This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";
        string find = "is";

        ExtractSentence(input, find);
    }

    public static void ExtractSentence(string input, string find)
    {
        //string pattern = @""; 
        string pattern = string.Format(@"(?<=^|\.)[^.]*?(? =\b{0}\b).*(\.|$)", Regex.Escape(find));
        Regex regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        MatchCollection matches = regex.Matches(input);

        Match m = Regex.Match(input, pattern);

        if(m.Success)
        {
            Console.WriteLine(m.Value);
        }

    }
}