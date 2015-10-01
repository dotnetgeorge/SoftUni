namespace BankOfKurtovoKonare.Accounts
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
            
        }

        public override void Withdraw(decimal withdral)
        {
            Console.WriteLine("Your account is Mortagage.");
            Console.WriteLine("You can not withdraw money only deposit!");
        }

        public override decimal InterestAmount(int months)
        {
            decimal amount;

            if (AccountType == Customer.Individual)
            {
                if (months - 6 < 0)
                {
                    return 0m;
                }
                else
                {
                    amount = base.InterestAmount(months - 6);
                }
            }
            else
            {
                if (months > 12)
                {
                    var firstYear = base.InterestAmount(12) / 2;
                    amount = firstYear + base.InterestAmount(months - 12);
                }
                else
                {
                    amount = base.InterestAmount(months) / 2;
                }
            }

            return amount;
        }
    }
}
