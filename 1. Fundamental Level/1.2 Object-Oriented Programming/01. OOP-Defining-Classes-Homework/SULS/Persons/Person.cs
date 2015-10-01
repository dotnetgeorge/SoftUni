using System;

namespace SULS.Persons
{
    public abstract class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="age">The age.</param>
        protected Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        /// <exception cref="System.ArgumentNullException">First name can not be null or empty!</exception>
        public string FirstName
        {
            get { return _firstName; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "First name can not be null or empty!");
                }

                _firstName = value;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Last name can not be null or empty!</exception>
        public string LastName
        {
            get { return _lastName; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Last name can not be null or empty!");
                }

                _lastName = value;
            }
        }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Age should be in range [1..100]!</exception>
        public int Age
        {
            get { return _age; }
            protected set
            {
                if (value < 1 || 100 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age should be in range [1..100]!");
                }

                _age = value;
            }
        }
    }
}
