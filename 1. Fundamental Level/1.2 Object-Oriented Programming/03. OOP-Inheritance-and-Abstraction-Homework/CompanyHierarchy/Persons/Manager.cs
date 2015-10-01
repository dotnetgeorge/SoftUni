namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Manager : Employee, IManager
    {
        private IList<Employee> _employees;

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        public Manager(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            Employees = new List<Employee>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Manager"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        /// <param name="employees">The employees.</param>
        public Manager(int id, string firstName, string lastName, double salary, Department department, IList<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            Employees = employees;
        }

        /// <summary>
        /// Gets or sets the employees.
        /// </summary>
        /// <value>
        /// The employees.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">You can't be manager to no one!</exception>
        public IList<Employee> Employees
        {
            get
            {
                return _employees;
            }
            set
            {
                if(value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "You can't be manager to no one!");
                }

                _employees = value;
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
            var manager = new StringBuilder();

            manager.AppendLine("Manager Info");
            manager.Append(base.ToString());
            manager.AppendLine("Manager Employees:");

            foreach (var employee in Employees)
            {
                manager.Append(employee);
            }

            return manager.ToString();
        }
    }
}
