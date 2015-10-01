namespace SULS.Persons
{
    public class GraduateStudent : Student
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GraduateStudent"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="studentNumber">The student number.</param>
        /// <param name="averageGrade">The average grade.</param>
        public GraduateStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            
        }
    }
}
