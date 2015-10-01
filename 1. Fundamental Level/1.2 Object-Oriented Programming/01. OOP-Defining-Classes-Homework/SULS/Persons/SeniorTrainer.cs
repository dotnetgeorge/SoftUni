namespace SULS.Persons
{
    using System;

    public class SeniorTrainer : Trainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeniorTrainer"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        public SeniorTrainer(string firstName, string lastName, int age) 
            : base(firstName, lastName, age)
        {
            
        }

        /// <summary>
        /// Deletes the course.
        /// </summary>
        /// <param name="course">The course.</param>
        public void DeleteCourse(string course)
        {
            Console.WriteLine("{0} course successfully deleted!", course);
        }
    }
}
