using Persons.Data;
using static System.Console;

namespace Persons
{
    class TestPerson
    {
        static void Main()
        {
            Write("Enter name of person: ");
            var name = ReadLine();

            Write("Enter age of person: ");
            var age = int.Parse(ReadLine());

            Write("Enter email of person(can be null): ");
            var email = ReadLine();

            var firstPerson = new Person(name, age);
            var secondPerson = new Person(name, age, email);

            WriteLine(firstPerson.ToString());
            WriteLine(secondPerson.ToString());
        }
    }
}
