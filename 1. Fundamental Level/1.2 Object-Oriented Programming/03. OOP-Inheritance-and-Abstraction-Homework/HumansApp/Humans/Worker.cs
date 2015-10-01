namespace HumansApp.Humans
{
    using System;

    public class Worker : Human
    {
        private double _weekSalary;
        private double _workHoursPerDay;

        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Worker(string firstName, string lastName) 
            : base(firstName, lastName)
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Worker"/> class.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="weekSalary">The week salary.</param>
        /// <param name="workHoursPerDay">The work hours per day.</param>
        public Worker(string firstName, string lastName, double weekSalary, double workHoursPerDay) 
            : base(firstName, lastName)
        {
            WeekSalary = weekSalary;
            WorkHoursPerDay = workHoursPerDay;
        }

        /// <summary>
        /// Gets or sets the week salary.
        /// </summary>
        /// <value>
        /// The week salary.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">You can't work for under 1lv. per week!</exception>
        public double WeekSalary
        {
            get
            {
                return _weekSalary;
            }
            set
            {
                if(value < 1.0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "You can't work for under 1lv. per week!");
                }

                _weekSalary = value;
            }
        }

        /// <summary>
        /// Gets or sets the work hours per day.
        /// </summary>
        /// <value>
        /// The work hours per day.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">Enter work hours in range [1..24]!</exception>
        public double WorkHoursPerDay
        {
            get
            {
                return _workHoursPerDay;
            }
            set
            {
                if(value < 1.0 || 24 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Enter work hours in range [1..24]!");
                }

                _workHoursPerDay = value;
            }
        }

        /// <summary>
        /// Moneys the per hour.
        /// </summary>
        /// <returns></returns>
        public double MoneyPerHour()
        {
            var moneyPerHour = (WeekSalary / 5) / WorkHoursPerDay;

            return moneyPerHour;
        }
    }
}
