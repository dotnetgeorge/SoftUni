namespace HumansApp.Humans
{
    using System;

    public abstract class Human
    {
        private string _firstName;
        private string _lastName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Human"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        protected Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        /// <exception cref="ArgumentNullException">First name can't be null or empty!</exception>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            protected set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "First name can't be null or empty!");
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
        /// <exception cref="ArgumentNullException">Last name can't be null or empty!</exception>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Last name can't be null or empty!");
                }

                _lastName = value;
            }
        }
    }
}
