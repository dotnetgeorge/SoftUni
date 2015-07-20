/*
 * Problem 6.	Count Symbols
 * Write a program that reads some text from the console and counts the occurrences of each character in it. 
 * Print the results in alphabetical (lexicographical) order.  
 */
using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
    static void Main(string[] args)
    {
        SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

        Console.Write("Enter something: ");
        string readLine = Console.ReadLine();

        CountAllSymbols(ref symbols, readLine);
        PrintSymbols(symbols);
    }

    public static void CountAllSymbols(ref SortedDictionary<char, int> symbols, string readLine)
    {
        HashSet<char> selected = new HashSet<char>();

        int length = readLine.Length;
        int count;
        char symbol = '\0';

        for (int i = 0; i < length; i++)
        {
            symbol = readLine[i];

            if (!selected.Contains(symbol))
            {
                count = readLine.Count(x => x == symbol);
                symbols.Add(symbol, count);
                selected.Add(symbol);
            }
        }
    }

    public static void PrintSymbols(SortedDictionary<char, int> symbols)
    {
        foreach (var item in symbols)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}