using System;
using BookShop.Data;

class BookShopApp
{
    static void Main(string[] args)
    {
        Book house = new Book("House of Cards", "Mark", 1.0);
        GoldenEditionBook wolf = new GoldenEditionBook("Wolf of Wall Street", "Jordan Belfard", 55.34);

        Console.WriteLine(house.ToString());
        Console.WriteLine(wolf.ToString());
    }
}