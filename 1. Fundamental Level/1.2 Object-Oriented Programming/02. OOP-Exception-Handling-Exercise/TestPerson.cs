using System;
using ValidPerson.Data;

class TestPerson
{
    static void Main(string[] args)
    {
        Person pesho = new Person("Pesho", "Peshev", 24);
        Person noName = new Person(string.Empty, "Goshev", 31);
        Person noLastName = new Person("Ivan", string.Empty, 63);
        Person negativeAge = new Person("Stoyan", "Kolev", -1);
        Person tooOldForThisProgram = new Person("Iskren", "Ivanov", 121);

        TryCatch();
    }

    public static void TryCatch()
    {
        try
        {
            Person noName = new Person(string.Empty, "Goshev", 31);
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine("Exception thrown: {0}", ane.Message);
        }
        catch(ArgumentOutOfRangeException aoore)
        {
            Console.WriteLine("Exception thrown: {0}", aoore.Message);
        }
    }
}