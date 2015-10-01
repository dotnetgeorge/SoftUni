namespace BankOfKurtovoKonare.Accounts
{
    using System;

    public class LoanAccount : Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoanAccount"/> class.
        /// </summary>
        /// <param name="customer">The customer.</param>
        /// <param name="balance">The balance.</param>
        /// <param name="interestRate">The interest rate.</param>
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            
        }

        /// <summary>
        /// Withdraws the specified withdral.
        /// </summary>
        /// <param name="withdral">The withdral.</param>
        public override void Withdraw(decimal withdral)
        {
            Console.WriteLine("Your account is Loan.");
            Console.WriteLine("You can not withdraw money, only deposit!");
        }

        public override decimal InterestAmount(int months)
        {
            var amount = InterestRate;

            if (AccountType == Customer.Individual)
            {
                amount = months - 3 < 0 ? 0m : base.InterestAmount(months - 3);
            }
            else
            {
                amount = months - 2 < 0 ? 0m : base.InterestAmount(months - 2);
            }

            return amount;
        }
    }
}
