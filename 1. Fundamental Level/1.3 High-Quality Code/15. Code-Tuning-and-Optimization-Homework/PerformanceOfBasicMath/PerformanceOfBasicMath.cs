/*
•	Write a program to compare the performance of add, subtract, increment, multiply, divide 
    for int, long, float, double and decimal values.
*/
using System;
using System.Diagnostics;

namespace PerformanceOfBasicMath
{
    class Program
    {
        static Stopwatch watch = new Stopwatch();
        static TimeSpan elapsed;
        static int firstNumber = 10;
        static long secondNumber = 10;
        static float thirdNumber = 10.0f;
        static double fourthNumber = 10.0d;
        static decimal fifthNumber = 10.0m;

        static void Main(string[] args)
        {
            Add();
            Subtract();
            Increment();
            Multiply();
            Divide();
        }

        public static void Add()
        {
            watch.Start();
            firstNumber += 1000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("int add", elapsed);

            watch.Start();
            secondNumber += 10000000000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("long add", elapsed);

            watch.Start();
            thirdNumber += 100000000000.0256564211f;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float add", elapsed);

            watch.Start();
            fourthNumber += 10000000000000.3546486465514654655464d;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double add", elapsed);

            watch.Start();
            fifthNumber += 534684846516554684.2554894765165465488m;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("decimal add", elapsed);

        }

        public static void Subtract()
        {
            watch.Start();
            firstNumber -= 1000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("int subtract", elapsed);

            watch.Start();
            secondNumber -= 10000000000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("long subtract", elapsed);

            watch.Start();
            thirdNumber -= 100000000000.0256564211f;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float subtract", elapsed);

            watch.Start();
            fourthNumber -= 10000000000000.3546486465514654655464d;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double subtract", elapsed);

            watch.Start();
            fifthNumber -= 534684846516554684.2554894765165465488m;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("decimal subtract", elapsed);
        }

        public static void Increment()
        {
            watch.Start();
            firstNumber++;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("int increment", elapsed);

            watch.Start();
            secondNumber++;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("long increment", elapsed);

            watch.Start();
            thirdNumber++;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float increment", elapsed);

            watch.Start();
            fourthNumber++;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double increment", elapsed);

            watch.Start();
            fifthNumber++;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("decimal increment", elapsed);
        }

        public static void Multiply()
        {
            watch.Start();
            firstNumber *= 1000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("int multiply", elapsed);

            watch.Start();
            secondNumber *= 10000000000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("long multiply", elapsed);

            watch.Start();
            thirdNumber *= 100000000000.0256564211f;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float multiply", elapsed);

            watch.Start();
            fourthNumber *= 10000000000000.3546486465514654655464d;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double multiply", elapsed);

            watch.Start();
            fifthNumber *= 534684846516554684.2554894765165465488m;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("decimal multiply", elapsed);
        }

        public static void Divide()
        {
            watch.Start();
            firstNumber /= 1000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("int divide", elapsed);

            watch.Start();
            secondNumber /= 10000000000000;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("long divide", elapsed);

            watch.Start();
            thirdNumber /= 100000000000.0256564211f;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float divide", elapsed);

            watch.Start();
            fourthNumber /= 10000000000000.3546486465514654655464d;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double divide", elapsed);

            watch.Start();
            fifthNumber /= 534684846516554684.2554894765165465488m;
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("decimal divide", elapsed);
        }

        static void PrintResult(string action, TimeSpan elapsed)
        {
            Console.WriteLine($"Action: '{action}'; Time elapsed: {elapsed}");
        }
    }
}
