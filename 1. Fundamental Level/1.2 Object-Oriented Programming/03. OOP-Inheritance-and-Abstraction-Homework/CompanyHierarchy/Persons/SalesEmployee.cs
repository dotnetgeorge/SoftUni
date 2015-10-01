namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class SalesEmployee : Employee, ISalesEmployee
    {
        private IList<Sale> _sales;

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesEmployee"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        public SalesEmployee(int id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName, salary, department)
        {
            Sales = new List<Sale>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SalesEmployee"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="salary">The salary.</param>
        /// <param name="department">The department.</param>
        /// <param name="sales">The sales.</param>
        public SalesEmployee(int id, string firstName, string lastName, double salary, Department department, IList<Sale> sales)
            : base(id, firstName, lastName, salary, department)
        {
            Sales = sales;
        }

        /// <summary>
        /// Gets or sets the sales.
        /// </summary>
        /// <value>
        /// The sales.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Sales employee should have at least 1 sale!</exception>
        public IList<Sale> Sales
        {
            get
            {
                return _sales;
            }
            set
            {
                if(value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Sales employee should have at least 1 sale!");
                }

                _sales = value;
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
            var salesEmployee = new StringBuilder();

            salesEmployee.AppendLine("Sales Employee Info");
            salesEmployee.Append(base.ToString());

            foreach (var sale in Sales)
            {
                salesEmployee.Append(sale);
            }

            return salesEmployee.ToString();
        }
    }
}
