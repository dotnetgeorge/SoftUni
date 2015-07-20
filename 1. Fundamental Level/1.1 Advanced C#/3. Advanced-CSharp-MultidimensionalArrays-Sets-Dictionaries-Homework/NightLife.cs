/*
 * Problem 8.	Night Life
 * Being a nerd means writing programs about night clubs instead of actually going to ones.
 * Spiro is a nerd and he decided to summarize some info about the most popular night clubs around the world. 
 * He's come up with the following structure – he'll summarize the data by city,
 * where each city will have a list of venues and each venue will have a list of performers. 
 * Help him finish the program, so he can stop staring at the computer screen and go get himself a cold beer.
 * You'll receive the input from the console. 
 * There will be an arbitrary number of lines until you receive the string "END". 
 * Each line will contain data in format: "city;venue;performer". 
 * If either city, venue or performer don't exist yet in the database, add them. 
 * If either the city and/or venue already exist, update their info.
 * Cities should remain in the order in which they were added,
 * venues should be sorted alphabetically and performers should be unique (per venue) and also sorted alphabetically.
 * Print the data by listing the cities and for each city its venues 
 * (on a new line starting with "->") and performers (separated by comma and space). 
 * Check the examples to get the idea. 
 * And grab a beer when you're done, you deserve it. 
 * Spiro is buying.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class NightLife
{
    public static Dictionary<string, Dictionary<string, List<string>>> cityEvents = new Dictionary<string,Dictionary<string,List<string>>>();
    public static Dictionary<string, List<string>> venuesPerformers = new Dictionary<string, List<string>>();
    public static List<string> performers = new List<string>();
    public static char[] separator = new char[] { ';' };
    public static string[] data = new string[0];

    static void Main(string[] args)
    {
        ReadData();
    }

    public static void ReadData()
    {
        string readLine = null;
        string city = null;
        string venue = null;
        string performer = null;

        while (true)
        {
            Console.Write("Enter city;venue;performer: ");
            readLine = Console.ReadLine();

            if(readLine == "END")
            {
                break;
            }

            data = readLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            city = data[0];
            venue = data[1];
            performer = data[2];

            if (!cityEvents.ContainsKey(city))
            {
                performers = new List<string>();
                performers.Add(performer);
                venuesPerformers.Add(venue, performers);
                cityEvents.Add(city, venuesPerformers);
            }
            else
            {
                if (cityEvents[city].ContainsKey(venue))
                {
                    cityEvents[city][venue].Add(performer);
                }
                else
                {
                    performers = new List<string>();
                    performers.Add(performer);
                    cityEvents[city].Add(venue, performers);
                }
            }
        }


        foreach (var item in cityEvents)
        {
            Console.WriteLine(item.Key);
            venuesPerformers = item.Value;

            foreach (var item2 in venuesPerformers)
            {
                Console.Write("->{0}: ", item2.Key);
                performers = item2.Value;

                foreach (var item3 in performers)
                {
                    Console.Write("{0}, ", item3);
                }
            }
        }
    }
}