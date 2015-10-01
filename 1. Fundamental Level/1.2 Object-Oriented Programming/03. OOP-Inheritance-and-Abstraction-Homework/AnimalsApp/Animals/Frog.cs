namespace AnimalsApp.Animals
{
    using System;

    public class Frog : Animal
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Frog"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        /// <param name="gender">The gender.</param>
        public Frog(string name, int age, string gender)
            : base(name, age, gender)
        {

        }

        /// <summary>
        /// Sounds the producible.
        /// </summary>
        public override void SoundProducible()
        {
            Console.WriteLine("Croak! Ribbit, ribbit! Croak!");
        }
    }
}
