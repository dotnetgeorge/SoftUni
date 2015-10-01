namespace SULS.Persons
{
    using System;

    public class Trainer : Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trainer"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        public Trainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
            
        }

        /// <summary>
        /// Creates the course.
        /// </summary>
        /// <param name="courseName">Name of the course.</param>
        public void CreateCourse(string courseName)
        {
            Console.WriteLine("{0} course successufully created!", courseName);
        }
    }
}
