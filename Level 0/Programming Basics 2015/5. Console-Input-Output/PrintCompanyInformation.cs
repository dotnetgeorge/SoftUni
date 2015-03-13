/*
 * Problem 2.	Print Company Information
 * A company has name, address, phone number, fax number, web site and manager. 
 * The manager has first name, last name, age and a phone number. 
 * Write a program that reads the information about a company and its manager and prints it back on the console.
 * program	user
 * Company name:	Software University
 * Company address:	26 V. Kanchev, Sofia
 * Phone number:	+359 899 55 55 92
 * Fax number:	
 * Web site:	http://softuni.bg
 * 
 * Manager first name:	Svetlin
 * Manager last name:	Nakov
 * Manager age:	25
 * Manager phone:	+359 2 981 981
 * Software University
 * Address: 26 V. Kanchev, Sofia
 * Tel. +359 899 55 55 92
 * Fax: (no fax)
 * Web site: http://softuni.bg
 * Manager: Svetlin Nakov (age: 25, tel. +359 2 981 981)	
 */
using System;

class PrintCompanyInformation
{
    static void Main(string[] args)
    {
        Console.Write("Enter Company Name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter Company Address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Enter Fax Number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Enter Web Site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Enter Manager First Name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter Manager Last Name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter Manager Age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Manager Phone Number: ");
        string managerPhoneNumber = Console.ReadLine();

        if(String.IsNullOrEmpty(companyFaxNumber) || String.IsNullOrWhiteSpace(companyFaxNumber))
        {
            companyFaxNumber = "(no fax)";
        }

        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + companyPhoneNumber);
        Console.WriteLine("Fax: " + companyFaxNumber);
        Console.WriteLine("Web site: " + companyWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);
    }
}