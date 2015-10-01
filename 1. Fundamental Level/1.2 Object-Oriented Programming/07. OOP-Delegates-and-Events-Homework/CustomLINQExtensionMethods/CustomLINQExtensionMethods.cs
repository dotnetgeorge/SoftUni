using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomLINQExtensionMethods.Data;

namespace CustomLINQExtensionMethods
{
    static class CustomLINQExtensionMethods
    {
        static void Main()
        {
            var collection = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var filteredCollection = collection.WhereNot(x => x % 2 == 0);
            Console.WriteLine(string.Join(", ", filteredCollection));


            var students = new List<Student>()
            {
                new Student("Pesho", 3),
                new Student("Gosho", 2),
                new Student("Mariika", 7),
                new Student("Stamat", 5)
            };

            Console.WriteLine(students.Max(x => x.Grade));

        }

        public static IEnumerable<T> WhereNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            var results = new List<T>();

            foreach (var item in collection)
            {
                if(!predicate(item))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        //public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection, Func<TSource, TSelector> predicate) where TSource : IComparable
        //{
        //    var array = collection.ToArray();
        //    Array.Sort(array);

        //    predicate = 
        //        () =>
        //        {
                    
        //        };

        //    for (int i = array.Length - 1; i >= 0; i--)
        //    {
        //        if(predicate(array[i]))
        //        {
                    
        //        }
        //    }

        //    return;
        //}
    }
}
