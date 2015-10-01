namespace SULS.Persons
{
    using System;

    public class CurrentStudent : Student
    {
        private string _currentCourse;

        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentStudent"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="studentNumber">The student number.</param>
        /// <param name="averageGrade">The average grade.</param>
        /// <param name="currentCourse">The current course.</param>
        public CurrentStudent(string firstName, string lastName, int age, string studentNumber, double averageGrade, string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            _currentCourse = currentCourse;
        }

        /// <summary>
        /// Gets or sets the current course.
        /// </summary>
        /// <value>
        /// The current course.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Current course can not be null or empty!</exception>
        public string CurrentCourse
        {
            get { return _currentCourse; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Current course can not be null or empty!");
                }

                _currentCourse = value;
            }
        }
    }
}
