namespace ValidPerson.Data
{
    using System;

    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "First name can't be null or empty!");
                }

                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("value", "Last name can't be null or empty!");
                }

                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(age < 1 || 120 < age)
                {
                    throw new ArgumentOutOfRangeException("value", "Enter valid age!\nAge should be in range [0..120]");
                }

                age = value;
            }
        }
    }
}
