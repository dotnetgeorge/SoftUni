namespace DefineClassDog.Data
{
    using System;

    public class Dog
    {
        public Dog() : 
            this(null, null)
        { }

        public Dog(string name, string breed)
        {
            this.Breed = breed;
            this.Name = name;
        }

        public string Name { get; set; }
        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("{0} ({1}) said: Bauuuuu!", this.Name ?? "[unnamed dog]", this.Breed ?? "[unknown breed]");
        }
    }
}
