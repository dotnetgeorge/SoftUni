using BankOfKurtovoKonare.Accounts;

namespace BankOfKurtovoKonare
{
    class TestBankApp
    {
        static void Main(string[] args)
        {
            var d = new DepositAccount(Customer.Company, 100000m, 3.54m);

            d.Deposit(5555);
        }
    }
}