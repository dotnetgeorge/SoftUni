namespace AnimalsApp.Animals
{
    using Interfaces;
    using System;


    public abstract class Animal : ISoundProducible
    {
        private string _name;
        private int _age;
        private string _gender;

        /// <summary>
        /// Initializes a new instance of the <see cref="Animal"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="age">The age.</param>
        /// <param name="gender">The gender.</param>
        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Name can't be null or empty!</exception>
        public string Name
        {
            get
            {
                return _name;
            }
            protected set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Name can't be null or empty!");
                }

                _name = value;
            }
        }

        /// <summary>
        /// Gets or sets the age.
        /// </summary>
        /// <value>
        /// The age.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Age should be in range [1..50]!</exception>
        public int Age
        {
            get
            {
                return _age;
            }
            protected set
            {
                if(value < 1 || 50 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age should be in range [1..50]!");
                }

                _age = value;
            }
        }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        /// <exception cref="System.ArgumentNullException">Gender can't be null or empty!</exception>
        public string Gender
        {
            get
            {
                return _gender;
            }
            protected set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Gender can't be null or empty!");
                }

                _gender = value;
            }
        }

        /// <summary>
        /// Sounds the producible.
        /// </summary>
        public abstract void SoundProducible();
    }
}
