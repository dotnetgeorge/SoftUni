namespace CompanyHierarchy.Persons
{
    using Interfaces;
    using System;
    using System.Text;

    public class Customer : Person, ICustomer
    {
        /// <summary>
        /// The net purchase amount
        /// </summary>
        private double _netPurchaseAmount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        public Customer(int id, string firstName, string lastName)
            : base(id, firstName, lastName)
        {
            _netPurchaseAmount = 0.00;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="netPurchaseAmount">The net purchase amount.</param>
        public Customer(int id, string firstName, string lastName, double netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            NetPurchaseAmount = netPurchaseAmount;
        }


        /// <summary>
        /// Gets or sets the net purchase amount.
        /// </summary>
        /// <value>
        /// The net purchase amount.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">You can't buy something under 1lv.!</exception>
        public double NetPurchaseAmount
        {
            get
            {
                return _netPurchaseAmount;
            }
            set
            {
                if(value < 1.00)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "You can't buy something under 1lv.!");
                }

                _netPurchaseAmount += value;
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
            var customer = new StringBuilder();

            customer.AppendLine("Customer Info");
            customer.Append(base.ToString());
            customer.AppendFormat("Net Purchase Amount: {0}{1}", NetPurchaseAmount, Environment.NewLine);

            return customer.ToString();
        }
    }
}
