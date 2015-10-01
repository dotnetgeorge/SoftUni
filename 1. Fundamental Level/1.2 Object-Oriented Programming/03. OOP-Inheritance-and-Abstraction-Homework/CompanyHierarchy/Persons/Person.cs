namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Text;

    public abstract class Person : IPerson
    {
        private int _id;
        private string _firstName;
        private string _lastName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Person ID can't be under 1!</exception>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Person ID can't be under 1!");
                }

                _id = value;
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        /// <exception cref="System.ArgumentNullException">First name can't be null or empty!</exception>
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
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
        /// <exception cref="System.ArgumentNullException">Last name can't be null or empty!</exception>
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Last name can't be null or empty!");
                }

                _lastName = value;
            }
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var person = new StringBuilder();

            person.AppendFormat("ID: {0}{1}", Id, Environment.NewLine);
            person.AppendFormat("First Name: {0}{1}", FirstName, Environment.NewLine);
            person.AppendFormat("Last Name: {0}{1}", LastName, Environment.NewLine);

            return person.ToString();
        }
    }
}
