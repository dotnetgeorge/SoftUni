using DefineClassDog.Data;

class Program
{
    static void Main(string[] args)
    {
        Dog unnamed = new Dog();
        Dog sharo = new Dog("Sharo", "Melez");

        unnamed.Breed = "Germam Shepherd";

        unnamed.Bark();
        sharo.Bark();
    }
}