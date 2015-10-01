namespace BankOfKurtovoKonare.Accounts
{
    using System;
    using Interfaces;

    public enum Customer
    {
        Individual,
        Company
    }

    public abstract class Account : IAccount
    {
        private decimal _balance;
        private decimal _interestRate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="accountType">Type of the account.</param>
        /// <param name="balance">The balance.</param>
        /// <param name="interestRate">The interest rate.</param>
        protected Account(Customer accountType, decimal balance, decimal interestRate)
        {
            AccountType = accountType;
            Balance = balance;
            InterestRate = interestRate;
        }

        /// <summary>
        /// Gets or sets the type of the account.
        /// </summary>
        /// <value>
        /// The type of the account.
        /// </value>
        public Customer AccountType { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>
        /// The balance.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Balance should be in range [-200,000..200,000]lv.!</exception>
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < -200000 || 200000 < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Balance should be in range [-200,000..200,000]lv.!");
                }

                _balance = value;
            }
        }

        /// <summary>
        /// Gets or sets the interest rate.
        /// </summary>
        /// <value>
        /// The interest rate.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">Interest rate should be in range [0.00..100]%!</exception>
        public decimal InterestRate
        {
            get { return _interestRate; }
            set
            {
                if (value < 0.00m || 100m < value)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Interest rate should be in range [0.00..100]%!");
                }

                _interestRate = value;
            }
        }

        /// <summary>
        /// Deposits the specified deposit.
        /// </summary>
        /// <param name="deposit">The deposit.</param>
        public virtual void Deposit(decimal deposit)
        {
            Balance += deposit;
            Console.WriteLine("Successfully withdraw money: {0:C2}", deposit);
            Console.WriteLine("Your balance is: {0:C2}", Balance);
        }

        /// <summary>
        /// Withdraws the specified withdral.
        /// </summary>
        /// <param name="withdral">The withdral.</param>
        public abstract void Withdraw(decimal withdral);

        /// <summary>
        /// Interests the amount.
        /// </summary>
        /// <param name="months">The months.</param>
        /// <returns></returns>
        public virtual decimal InterestAmount(int months)
        {
            var amount = Balance*(1 + InterestRate*months);
            return amount;
        }
    }
}
