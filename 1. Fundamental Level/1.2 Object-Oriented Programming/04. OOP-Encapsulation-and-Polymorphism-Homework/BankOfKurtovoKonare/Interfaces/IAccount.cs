namespace BankOfKurtovoKonare.Interfaces
{
    using Accounts;

    public interface IAccount
    {
        /// <summary>
        /// Gets or sets the type of the account.
        /// </summary>
        /// <value>
        /// The type of the account.
        /// </value>
        Customer AccountType { get; set; }

        /// <summary>
        /// Gets or sets the balance.
        /// </summary>
        /// <value>
        /// The balance.
        /// </value>
        decimal Balance { get; set; }

        /// <summary>
        /// Gets or sets the interest rate.
        /// </summary>
        /// <value>
        /// The interest rate.
        /// </value>
        decimal InterestRate { get; set; }

        void Deposit(decimal deposit);

        void Withdraw(decimal withdral);
    }
}
