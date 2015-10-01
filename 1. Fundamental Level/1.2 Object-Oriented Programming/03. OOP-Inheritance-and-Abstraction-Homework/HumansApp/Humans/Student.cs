namespace HumansApp.Humans
{
    using System;

    public class Student : Human
    {
        /// <summary>
        /// The faculty number
        /// </summary>
        private string _facultyNumber;

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="facultyNumber">The faculty number.</param>
        public Student(string firstName, string lastName, string facultyNumber) 
            : base(firstName, lastName)
        {
            FacultyNumber = facultyNumber;   
        }

        /// <summary>
        /// Gets or sets the faculty number.
        /// </summary>
        /// <value>
        /// The faculty number.
        /// </value>
        /// <exception cref="ArgumentNullException">Faculty number can't be null or empty!</exception>
        public string FacultyNumber
        {
            get
            {
                return _facultyNumber;
            }
            protected set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Faculty number can't be null or empty!");
                }

                _facultyNumber = value;
            }
        }
    }
}
