/*
 * Problem 9.	Remove Names
 * Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
 * The input and output lists are given as words, separated by a space, each list at a separate line.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main(string[] args)
    {
        Console.Write("Enter names: ");
        string readNames = Console.ReadLine();

        Console.Write("Enter names to remove: ");
        string readNamesToRemove = Console.ReadLine();

        char[] separator = new char[] { ' ' };
        List<string> names = readNames.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
        List<string> removeNames = readNamesToRemove.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();

        RemoveNamesFromList(ref names, removeNames);

        removeNames.Clear();

        PrintNames(names);

    }

    public static void RemoveNamesFromList(ref List<string> names, List<string> removeNames)
    {
        int removeNamesLength = removeNames.Count;
        string name = null;

        for (int i = 0; i < removeNamesLength; i++)
        {
            name = removeNames[i];
            names.RemoveAll(x => x.Equals(name));
        }
    }

    public static void PrintNames(List<string> names)
    {
        foreach (var name in names)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}