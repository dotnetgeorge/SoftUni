/*
•	Write a program to compare the performance of square root, natural logarithm, sinus 
        for float, double and decimal values.
*/
using System;
using System.Diagnostics;

namespace PerformanceOfTrigonometry
{
    class Program
    {
        static Stopwatch watch = new Stopwatch();
        static TimeSpan elapsed;
        static float firstNumber = 1445.4355f;
        static double secondNumber = 54646465545.165789842232d;
        static decimal thirdNumber = 455561654646.654657987465146m;

        static void Main(string[] args)
        {
            SquareRoot();
            Logarithm();
            Sinus();
        }

        public static void SquareRoot()
        {
            watch.Start();
            firstNumber = (float)Math.Sqrt(firstNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float square root", elapsed);

            watch.Start();
            secondNumber = Math.Sqrt(secondNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double square root", elapsed);

            watch.Start();
            thirdNumber = (decimal)Math.Sqrt((double)thirdNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("Decimal square root", elapsed);
        }

        public static void Logarithm()
        {
            watch.Start();
            firstNumber = (float)Math.Log(firstNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float natural logarithm", elapsed);

            watch.Start();
            secondNumber = Math.Log(secondNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double natural logarithm", elapsed);

            watch.Start();
            thirdNumber = (decimal)Math.Log((double)thirdNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("Decimal natural logarithm", elapsed);
        }

        public static void Sinus()
        {
            watch.Start();
            firstNumber = (float)Math.Sin(firstNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("float sinus", elapsed);

            watch.Start();
            secondNumber = Math.Sin(secondNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("double sinus", elapsed);

            watch.Start();
            thirdNumber = (decimal)Math.Sin((double)thirdNumber);
            watch.Stop();
            elapsed = watch.Elapsed;
            PrintResult("Decimal sinus", elapsed);
        }

        static void PrintResult(string action, TimeSpan elapsed)
        {
            Console.WriteLine($"Action: '{action}'; Time elapsed: {elapsed}");
        }
    }
}
