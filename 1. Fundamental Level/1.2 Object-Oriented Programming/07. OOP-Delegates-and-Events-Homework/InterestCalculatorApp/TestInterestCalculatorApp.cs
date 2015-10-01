using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterestCalculatorApp.Data;

namespace InterestCalculatorApp
{
    class TestInterestCalculatorApp
    {
        

        static void Main(string[] args)
        {
            var simpleInterest = new InterestCalculator(500, 0.056, 10, GetSimpleInterest);

            var compoundInterest = new InterestCalculator(2500, 0.072, 15, GetCompoundInterest);


            Console.WriteLine(simpleInterest.Balance);
            Console.WriteLine(compoundInterest.Balance);
        }


        public static double GetSimpleInterest(int money, double interestRate, int years)
        {
            var interest = 1 + (interestRate * years);
            var simpleInterest = money * interest;

            return Math.Round(simpleInterest, 4);
        }

        public static double GetCompoundInterest(int money, double interestRate, int years)
        {
            var pow = years * 12;
            var getInterest = (1 + (interestRate / 12));
            var compoundInterest = money * Math.Pow(getInterest, pow);

            return Math.Round(compoundInterest, 4);
        }
    }
}
