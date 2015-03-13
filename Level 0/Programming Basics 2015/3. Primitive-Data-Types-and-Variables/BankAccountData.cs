/*
 * Problem 11.	Bank Account Data
 * A bank account has a holder name (first name, middle name and last name),
 * available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. 
 * Declare the variables needed to keep the information for a single bank account
 * using the appropriate data types and descriptive names.
 */
using System;

class BankAccountData
{
    static void Main(string[] args)
    {
        string firstName = "Chad";
        string middleName = "Alison";
        string lastName = "Loesch";
        decimal balance = 5894893.21m;
        string bankName = "Bank of England";
        string IBAN = "GB29 NWBK 6016 1331 9268 19";
        long firstCreditCard = 4916871566964598;
        long secondCreditCard = 4929175253880124;
        long thirdCreditCard = 5106178469319335;

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Middle Name: " + middleName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Balance: " + balance);
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("IBAN: " + IBAN);
        Console.WriteLine("First Credit Card: " + firstCreditCard);
        Console.WriteLine("Second Credit Card: " + secondCreditCard);
        Console.WriteLine("Third Credit Card: " + thirdCreditCard);
    }
}