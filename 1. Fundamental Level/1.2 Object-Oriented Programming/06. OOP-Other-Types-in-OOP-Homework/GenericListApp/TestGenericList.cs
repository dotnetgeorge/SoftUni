using System;
using GenericListApp.Data;

namespace GenericListApp
{
    class TestGenericList
    {
        static void Main(string[] args)
        {
            var list = new GenericList<char>();

            for (int i = 0; i <= 127; i++)
            {
                list.Add((char)i);
            }

            Console.WriteLine(list.ToString());


        }
    }
}
