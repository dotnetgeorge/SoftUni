namespace SULS.Persons
{
    using System;

    public class Student : Person
    {
        private string _studentNumber;
        private double _averageGrade;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        /// <param name="studentNumber">The student number.</param>
        /// <param name="averageGrade">The average grade.</param>
        public Student(string firstName, string lastName, int age, string studentNumber, double averageGrade)
            : base(firstName, lastName, age)
        {
            StudentNumber = studentNumber;
            AverageGrade = averageGrade;
        }

        /// <summary>
        /// Gets or sets the student number.
        /// </summary>
        /// <value>
        /// The student number.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Student number can not be null or empty!</exception>
        public string StudentNumber
        {
            get { return _studentNumber; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Student number can not be null or empty!");
                }

                _studentNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets the average grade.
        /// </summary>
        /// <value>
        /// The average grade.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Average grade should be in range [1..100]!</exception>
        public double AverageGrade
        {
            get { return _averageGrade; }
            protected set
            {
                if (value < 0.00 || 100 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Average grade should be in range [1..100]!");
                }

                _averageGrade = value;
            }
        }
    }
}
