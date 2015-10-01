namespace Persons.Data
{
    using System;

    public class Person
    {
        private string _name;
        private int _age;
        private string _email;

        public Person()
        {
            _name = "John Smith";
            _age = 20;
            _email = "johnsmith@gmail.com";
        }

        public Person(string name, int age)
        {
            _name = name;
            _age = age;
            _email = null;
        }

        public Person(string name, int age, string email)
        {
            _name = name;
            _age = age;
            _email = email;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Can't pass empty name!");
                }

                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 1 || value > 100)
                {
                    throw new InvalidOperationException("Enter a real age!");
                }

                _age = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if(!value.Contains("@") && !string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Incorrect email!");
                }

                _email = value;
            }
        }

        public override string ToString()
        {
            var person = string.Format("Person Name: {0}\nPerson Age: {1}\nPerson E-mail: {2}", Name, Age, Email);

            return person;
        }
    }
}
