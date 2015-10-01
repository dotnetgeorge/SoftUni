namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Text;

    public enum Department
    {
        Production,
        Accounting,
        Sales,
        Marketing
    }

    public class Employee : Person, IEmployee
    {
        private double _salary;
        private Department _selectedDepartment;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        public Employee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName)
        {
            Salary = salary;
            SelectedDepartment = department;
        }

        /// <summary>
        /// Gets or sets the salary.
        /// </summary>
        /// <value>
        /// The salary.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Salary can't be under 1lv.!</exception>
        public double Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if(value < 1.0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Salary can't be under 1lv.!");
                }

                _salary = value;
            }
        }

        /// <summary>
        /// Gets or sets the selected department.
        /// </summary>
        /// <value>
        /// The selected department.
        /// </value>
        /// <exception cref="System.ArgumentException">Please select between Accounting|Production|Sales or Marketing!</exception>
        public Department SelectedDepartment
        {
            get
            {
                return _selectedDepartment;
            }
            set
            {
                //if(value != Department.Accounting || value != Department.Production || value != Department.Sales)
                //{
                //    throw new ArgumentException("Please select between Accounting|Production|Sales or Marketing!");
                //}

                _selectedDepartment = value;
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
            var employee = new StringBuilder();

            employee.Append(base.ToString());
            employee.AppendFormat("Salary: {0:F2}{1}", Salary, Environment.NewLine);
            employee.AppendFormat("Department: {0}{1}", SelectedDepartment, Environment.NewLine);

            return employee.ToString();
        }
    }
}
