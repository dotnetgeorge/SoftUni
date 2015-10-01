namespace SULS.Persons
{
    public class OnlineStudent : CurrentStudent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineStudent"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="studentNumber">The student number.</param>
        /// <param name="averageGrade">The average grade.</param>
        /// <param name="currentCourse">The current course.</param>
        public OnlineStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {

        }
    }
}
