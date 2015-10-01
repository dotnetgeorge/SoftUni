namespace AnimalsApp.Animals
{
    using System;

    public class Cat : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Cat"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        /// <param name="gender">The gender.</param>
        public Cat(string name, int age, string gender) 
            : base(name, age, gender)
        {

        }

        /// <summary>
        /// Sounds the producible.
        /// </summary>
        public override void SoundProducible()
        {
            Console.WriteLine("Meow! Meow! Meoooooowwww!");
        }
    }
}
