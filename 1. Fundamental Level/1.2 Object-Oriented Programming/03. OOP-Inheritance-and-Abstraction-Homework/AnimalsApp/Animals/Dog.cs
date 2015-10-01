namespace AnimalsApp.Animals
{
    using System;

    public class Dog : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Dog"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        /// <param name="gender">The gender.</param>
        public Dog(string name, int age, string gender) 
            : base(name, age, gender)
        {

        }

        /// <summary>
        /// Sounds the producible.
        /// </summary>
        public override void SoundProducible()
        {
            Console.WriteLine("Bark! Bark! Bark!");
        }
    }
}
