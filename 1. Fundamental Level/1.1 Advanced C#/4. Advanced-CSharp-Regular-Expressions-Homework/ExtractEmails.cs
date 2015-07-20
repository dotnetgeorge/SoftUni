/*
 * Problem 3.	Extract Emails
 * Write a program to extract all email addresses from a given text. 
 * The text comes at the only input line. 
 * Print the emails on the console, each at a separate line. 
 * Emails are considered to be in format <user>@<host>, where: 
 * •	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. 
 *      Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". 
 *      Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". 
 *      
 * •	<host> is a sequence of at least two words, separated by dots '.'. 
 *      Each word is sequence of letters and can have hyphens '-' between the letters. 
 *      Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". 
 *      Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 
 *      
 * •	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, 
 *      s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
 *      
 * •	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld,
 *      mike@.unknown.soft., s.johnson@invalid-.
 */
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractEmails
{
    public static Queue<string> emails = new Queue<string>();
    public static string email;

    static void Main(string[] args)
    {
        Console.Write("Enter e-mails: ");
        string readEmails = Console.ReadLine();

        emails = ExtractEmailsFromInput(readEmails);

        PrintEmails(emails);
    }

    public static Queue<string> ExtractEmailsFromInput(string readEmails)
    {
        Regex regex = new Regex(@"[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]", RegexOptions.IgnoreCase | RegexOptions.Compiled);
        MatchCollection matches = regex.Matches(readEmails);

        foreach (Match match in matches)
        {
            email = match.Value.ToString();
            emails.Enqueue(email);
        }

        return emails;
    }

    public static void PrintEmails(Queue<string> emails)
    {
        foreach (var item in emails)
        {
            Console.WriteLine(item);
        }
    }
}