using System;
using System.Globalization;

class DifferenceBetweenDates
{
    public static double difference;

    static void Main(string[] args)
    {
        string format = "dd.mm.yyyy";

        Console.Write("Enter first date: ");
        DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        Console.Write("Enter second date: ");
        DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, CultureInfo.InvariantCulture);

        difference = GetDifference(firstDate, secondDate);

        Console.WriteLine(difference);


    }

    public static double GetDifference(DateTime firstDate, DateTime secondDate)
    {
        if(firstDate.Month > secondDate.Month)
        {
            difference = (firstDate - secondDate).TotalDays;

            return difference;
        }

        difference = (secondDate - firstDate).TotalDays;

        return difference;
    }
}