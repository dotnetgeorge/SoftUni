using System;
using LaptopsShop.Data;

namespace LaptopsShop
{
    class TestLaptopShop
    {
        public static LaptopShop LaptopShop;

        static void Main()
        {
            int option;
            var isFull = false;

            do
            {
                Console.WriteLine("Laptop Shop");
                Console.WriteLine("1. Model and Price");
                Console.WriteLine("2. Full Info");
                Console.Write("Plase select an option: ");
                option = int.Parse(Console.ReadLine());
            } while (option < 1 || option > 2);

            Console.Clear();

            switch (option)
            {
                case 1:
                    break;
                case 2:
                    isFull = true;
                    break;
            }

            LaptopShop = FillInfo(isFull);

            Console.WriteLine(LaptopShop.ToString());
        }

        public static LaptopShop FillInfo(bool isFull)
        {
            LaptopShop = new LaptopShop();
            string model;
            decimal price;

            if(isFull)
            {
                Console.Write("Enter Model: ");
                model = Console.ReadLine();

                Console.Write("Enter Manufacturer: ");
                var manufacturer = Console.ReadLine();

                Console.Write("Enter Processor: ");
                var processor = Console.ReadLine();

                Console.Write("Enter RAM");
                var ram = double.Parse(Console.ReadLine());

                Console.Write("Enter Graphics Card: ");
                var graphicsCard = Console.ReadLine();

                Console.Write("Enter HDD: ");
                var hdd = Console.ReadLine();

                Console.Write("Enter Screen: ");
                var screen = Console.ReadLine();

                Console.Write("Enter Battery Type: ");
                var batteryType = Console.ReadLine();

                Console.Write("Enter Battery Life: ");
                var batteryLife = Console.ReadLine();

                Console.Write("Enter Price: ");
                price = decimal.Parse(Console.ReadLine());

                LaptopShop = new LaptopShop();

                var batteryInfo = new Battery(batteryType, batteryLife);
                AddLaptop(ref LaptopShop, model, manufacturer, processor, ram, graphicsCard, hdd, screen, batteryInfo, price);
            }
            else
            {
                Console.Write("Enter Model: ");
                model = Console.ReadLine();

                Console.Write("Enter Price: ");
                price = decimal.Parse(Console.ReadLine());

                AddLaptop(ref LaptopShop, model, price);
            }

            Console.Clear();

            return LaptopShop;
        }

        public static void AddLaptop(ref LaptopShop laptopShop, string model, decimal price)
        {
            laptopShop.Model = model;
            laptopShop.Price = price;
        }

        public static void AddLaptop(ref LaptopShop laptopShop, string model, string manufacturer,
            string processor, double ram, string graphicsCard, string hdd, string screen, Battery batteryInfo, decimal price )
        {
            laptopShop.Model = model;
            laptopShop.Manufacturer = manufacturer;
            laptopShop.Processor = processor;
            laptopShop.Ram = ram;
            laptopShop.GraphicsCard = graphicsCard;
            laptopShop.Hdd = hdd;
            laptopShop.Screen = screen;
            laptopShop.BatteryInfo = batteryInfo;
            laptopShop.Price = price;
        }
    }
}
