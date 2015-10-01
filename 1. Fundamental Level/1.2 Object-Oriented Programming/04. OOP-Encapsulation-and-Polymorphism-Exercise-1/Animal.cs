namespace AnimalFarm
{
    using System;

    public abstract class Animal
    {
        private const int MinAnimalAge = 0;
        private const int MaxAnimalAge = 15;

        private string name;
        protected int age;

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name can't be null or empty!");
                }

                this.name = value;
            }
        }

        private int Age
        {
            get { return this.age; }

            set
            {
                if (value < MinAnimalAge || MaxAnimalAge < value)
                {
                    throw new ArgumentOutOfRangeException("Age should be in range[{0}..{1}]!", MinAnimalAge.ToString(), MaxAnimalAge.ToString());
                }

                this.age = value;
            }
        }

        public double ProductPerDay
        {
            get
            {
                return this.CalculateProductPerDay();
            }
        }

        protected abstract Product ProduceProduct();

        protected abstract double GetHumanAge();

        private double CalculateProductPerDay()
        {
            switch (this.age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}

