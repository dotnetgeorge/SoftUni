using System;
using System.Collections.Generic;
using PCCatalog.Data;

namespace PCCatalog
{
    class PcCatalog
    {
        public static List<Computer> Computers;
        public static Component Component;
        public static int Length;

        static void Main()
        {
            Console.Write("How many computers do you want to add: ");
            Length = int.Parse(Console.ReadLine());

            Computers = AddData(Length);

            PrintComputers(Computers);
        }

        public static List<Computer> AddData(int length)
        {
            Computers = new List<Computer>(length);
            var price = 0.0m;

            for (var i = 0; i < length; i++)
            {
                Console.WriteLine("Add Data About Computer #{0}", (i + 1));
                Console.Write("Enter name of computer: ");
                var name = Console.ReadLine();

                Console.Write("Enter Motherboard Name: ");
                var componentName = Console.ReadLine();

                Console.Write("Enter Motherboard Details: ");
                var componentDetails = Console.ReadLine();

                Console.Write("Enter Motherboard Price: ");
                price = decimal.Parse(Console.ReadLine());

                var motherboard = new Component(componentName, componentDetails, price);

                Console.Write("Enter Processor Name: ");
                componentName = Console.ReadLine();

                Console.Write("Enter Processor Details: ");
                componentDetails = Console.ReadLine();

                Console.Write("Enter Processor Price: ");
                price = decimal.Parse(Console.ReadLine());

                var processor = new Component(componentName, componentDetails, price);

                Console.Write("Enter RAM Name: ");
                componentName = Console.ReadLine();

                Console.Write("Enter RAM Details: ");
                componentDetails = Console.ReadLine();

                Console.Write("Enter RAM Price: ");
                price = decimal.Parse(Console.ReadLine());

                var ram = new Component(componentName, componentDetails, price);

                Console.Write("Enter HDD Name: ");
                componentName = Console.ReadLine();

                Console.Write("Enter HDD Details: ");
                componentDetails = Console.ReadLine();

                Console.Write("Enter HDD Price: ");
                price = decimal.Parse(Console.ReadLine());

                var hdd = new Component(componentName, componentDetails, price);

                Console.Write("Enter Graphics Card Name: ");
                componentName = Console.ReadLine();

                Console.Write("Enter Graphics Card Details: ");
                componentDetails = Console.ReadLine();

                Console.Write("Enter Graphics Card Price: ");
                price = decimal.Parse(Console.ReadLine());

                var graphicsCard = new Component(componentName, componentDetails, price);

                Console.Write("Enter Power Name: ");
                componentName = Console.ReadLine();

                Console.Write("Enter Power Details: ");
                componentDetails = Console.ReadLine();

                Console.Write("Enter Power Price: ");
                price = decimal.Parse(Console.ReadLine());

                var power = new Component(componentName, componentDetails, price);

                var computer = new Computer(name, motherboard, processor, ram, hdd, graphicsCard, power);
                Computers.Add(computer);

                Console.Clear();
            }

            return Computers;
        }

        public static void PrintComputers(List<Computer> computers)
        {
            Length = computers.Count;

            foreach (var computer in computers)
            {
                Console.WriteLine("Computer list contains info about {0} computer/s.", Length);
                Console.WriteLine(computer.ToString());
                Console.WriteLine("Enter random key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
