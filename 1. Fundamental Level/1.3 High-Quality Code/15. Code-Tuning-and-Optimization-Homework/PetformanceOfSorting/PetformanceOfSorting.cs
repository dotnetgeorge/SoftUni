/*
•	Write a program to compare the performance of insertion sort, selection sort, quicksort 
        for int, double and string values. 
    Check also the following cases: random values, sorted values, values sorted in reversed order.
*/
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PetformanceOfSorting
{
    class PetformanceOfSorting
    {
        static Stopwatch watch = new Stopwatch();
        static TimeSpan elapsed;
        static int[] realNumbers = new int[] { 10, 2, 5, 4, 3, 9, 7, 0, 6, 8, 1 };
        static double[] floatingNumbers = new double[] { 10.9, 2.665, 5.768, 4.234, 3.253, 9.533, 7.245, 0.99, 6.32, 8.56, 1.23 };
        static string[] words = new string[] { "wow", "such", "dog", "much", "btc", "doggy" };

        static void Main(string[] args)
        {
            InsertionSortPerformance();
            SelectionSortPerformance();
            QuickSortPerformance();
        }

        static void InsertionSortPerformance()
        {
            //Array.Sort(realNumbers);

            //realNumbers = realNumbers.OrderByDescending(x => x).ToArray();

            watch.Start();
            InsertionSort(ref realNumbers);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("int[]", "InsertionSort", elapsed);
            //Console.WriteLine(string.Join(", ", realNumbers));

            //floatingNumbers = floatingNumbers.OrderByDescending(x => x).ToArray();
            watch.Start();
            InsertionSort(ref floatingNumbers);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("double[]", "InsertionSort", elapsed);

            //words = words.OrderByDescending(x => x.Length).ToArray();

            watch.Start();
            InsertionSort(ref words);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("string[]", "InsertionSort", elapsed);
        }

        static void SelectionSortPerformance()
        {
            //Array.Sort(realNumbers);

            //realNumbers = realNumbers.OrderByDescending(x => x).ToArray();

            watch.Start();
            SelectionSort(ref realNumbers);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("int[]", "SelectionSort", elapsed);
            //Console.WriteLine(string.Join(", ", realNumbers));

            //floatingNumbers = floatingNumbers.OrderByDescending(x => x).ToArray();
            watch.Start();
            SelectionSort(ref floatingNumbers);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("double[]", "SelectionSort", elapsed);

            //words = words.OrderByDescending(x => x.Length).ToArray();

            watch.Start();
            SelectionSort(ref words);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("string[]", "SelectionSort", elapsed);
        }

        static void QuickSortPerformance()
        {
            //Array.Sort(realNumbers);

            //realNumbers = realNumbers.OrderByDescending(x => x).ToArray();

            watch.Start();
            QuickSort(ref realNumbers, 0, realNumbers.Length - 1);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("int[]", "QuickSort", elapsed);
            //Console.WriteLine(string.Join(", ", realNumbers));

            //floatingNumbers = floatingNumbers.OrderByDescending(x => x).ToArray();
            watch.Start();
            QuickSort(ref floatingNumbers, 0, floatingNumbers.Length - 1);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("double[]", "QuickSort", elapsed);

            //words = words.OrderByDescending(x => x.Length).ToArray();

            watch.Start();
            QuickSort(ref words, 0, words.Length - 1);
            watch.Stop();
            elapsed = watch.Elapsed;
            Print("string[]", "QuickSort", elapsed);
        }


        static void InsertionSort<T>(ref T[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                var number = arr[i];
                int index = i;

                while (index > 0 && Comparer<T>.Default.Compare(arr[index - 1], number) == 1)
                {
                    arr[index] = arr[index - 1];
                    index--;
                }

                arr[index] = number;
            }
        }

        static void SelectionSort<T>(ref T[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                var min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if(Comparer<T>.Default.Compare(arr[j], arr[min]) == -1)
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    var old = arr[i];
                    arr[i] = arr[min];
                    arr[min] = old;
                }
            }
        }

        public static void QuickSort<T>(ref T[] arr, int left, int right)
        {
            int leftIndex = left;
            int rightIndex = right;
            var compareTo = arr[(left + right) / 2];
            var comparer = Comparer<T>.Default;

            while (leftIndex < rightIndex)
            {
                while (comparer.Compare(arr[leftIndex], compareTo) < 0)
                {
                    leftIndex++;
                }

                while (comparer.Compare(arr[rightIndex], compareTo) > 0)
                {
                    rightIndex--;
                }

                if(leftIndex <= rightIndex)
                {
                    var tmp = arr[leftIndex];
                    arr[leftIndex] = arr[rightIndex];
                    arr[rightIndex] = tmp;

                    leftIndex++;
                    rightIndex--;
                }
            }

            if(left < rightIndex)
            {
                QuickSort(ref arr, left, rightIndex);
            }

            if(leftIndex < right)
            {
                QuickSort(ref arr, leftIndex, right);
            }

        }

        public static void Print(string dataType, string sortAlgorithm, TimeSpan elapsed)
        {
            Console.WriteLine($"Data Type: {dataType}; Sorting Algorithm: {sortAlgorithm}; Elapsed: {elapsed}");
        }
    }
}
