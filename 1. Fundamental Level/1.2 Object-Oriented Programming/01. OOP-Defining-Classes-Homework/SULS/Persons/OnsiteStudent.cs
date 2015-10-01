namespace SULS.Persons
{
    using System;

    public class OnsiteStudent : CurrentStudent
    {
        private int _numberOfVisits;

        /// <summary>
        /// Initializes a new instance of the <see cref="OnsiteStudent"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="studentNumber">The student number.</param>
        /// <param name="averageGrade">The average grade.</param>
        /// <param name="currentCourse">The current course.</param>
        /// <param name="numberOfVisits">The number of visits.</param>
        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            NumberOfVisits = numberOfVisits;
        }

        /// <summary>
        /// Gets or sets the number of visits.
        /// </summary>
        /// <value>
        /// The number of visits.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Number of visits can not be under 1!</exception>
        public int NumberOfVisits
        {
            get { return _numberOfVisits; }
            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Number of visits can not be under 1!");
                }

                _numberOfVisits = value;
            }
        }
    }
}
