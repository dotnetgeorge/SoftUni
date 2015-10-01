namespace AnimalsApp.Animals
{
    public class Kitten : Cat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Kitten"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        public Kitten(string name, int age)
            : base(name, age, "Female")
        {

        }
    }
}
