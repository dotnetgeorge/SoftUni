namespace BankOfKurtovoKonare.Accounts
{
    using System;

    public class DepositAccount : Account
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositAccount"/> class.
        /// </summary>
        /// <param name="accountType">Type of the account.</param>
        /// <param name="balance">The balance.</param>
        /// <param name="interestRate">The interest rate.</param>
        public DepositAccount(Customer accountType, decimal balance, decimal interestRate)
            : base(accountType, balance, interestRate)
        {

        }

        /// <summary>
        /// Withdraws the specified withdraw.
        /// </summary>
        /// <param name="withdraw">The withdraw.</param>
        public override void Withdraw(decimal withdraw)
        {
            if (withdraw >= Balance)
            {
                Balance -= withdraw;
                Console.WriteLine("Successfully withdraw amount: {0:C2}", withdraw);
                Console.WriteLine("Your balance is: {0:C2}", Balance);
            }
            else
            {
                Console.WriteLine("You can not withdraw {0:C2}, because your balance is {1:C2}", withdraw, Balance);
            }
        }

        /// <summary>
        /// Interests the amount.
        /// </summary>
        /// <param name="months">The months.</param>
        /// <returns></returns>
        public override decimal InterestAmount(int months)
        {
            if (0 < Balance && Balance < 1000)
            {
                return 0;
            }
            return base.InterestAmount(months);
        }
    }
}
