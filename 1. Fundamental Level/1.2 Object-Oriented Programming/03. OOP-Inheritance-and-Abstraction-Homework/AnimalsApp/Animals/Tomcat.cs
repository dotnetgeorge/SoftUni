namespace AnimalsApp.Animals
{
    public class Tomcat : Cat
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Tomcat"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        public Tomcat(string name, int age)
            : base(name, age, "Male")
        {

        }
    }
}
