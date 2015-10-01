using System;
using System.Collections.Generic;
using System.Linq;
using AnimalsApp.Animals;

namespace AnimalsApp
{
    internal class TestAnimalsApp
    {
        private static void Main()
        {
            var animals = new List<Animal>
            {
                new Cat("Liso", 1, "Female"),
                new Cat("Piso", 3, "Female"),
                new Dog("Sharo", 4, "Male"),
                new Dog("Rex", 8, "Male"),
                new Frog("Gogo", 5, "Male"),
                new Frog("Vilian", 3, "Male"),
                new Kitten("Mimi", 2),
                new Kitten("Fifi", 4),
                new Tomcat("Beast", 8),
                new Tomcat("Garfield", 5)
            };

            Console.WriteLine("Average Ages");

            var catAge = from cat in animals
                where cat.GetType() == typeof(Cat)
                select cat.Age;

            Console.WriteLine("Cat: {0}", catAge.Average());

            var dogAge = from dog in animals
                where dog.GetType() == typeof(Dog)
                select dog.Age;

            Console.WriteLine("Dog: {0}", dogAge.Average());

            var frogAge = from frog in animals
                where frog.GetType() == typeof(Frog)
                select frog.Age;

            Console.WriteLine("Frog: {0}", frogAge.Average());

            var kittenAge = from kitten in animals
                where typeof(Kitten) == kitten.GetType()
                select kitten.Age;

            Console.WriteLine("Kitten: {0}", kittenAge.Average());

            var tomcatAge = from tomcat in animals
                where tomcat.GetType() == typeof(Tomcat)
                select tomcat.Age;

            Console.WriteLine("Tomcat: {0}", tomcatAge.Average());
        }
    }
}