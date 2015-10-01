namespace InterestCalculatorApp.Data
{
    using System;

    public delegate double CalculateInterest(int sumOfMoney, double interestRate, int years);

    public class InterestCalculator
    {
        private readonly CalculateInterest _calculateInterest;
        private int _sumOfMoney;
        private double _interestRate;
        private int _years;

        public InterestCalculator(int sumOfMoney, double interestRate, int years, CalculateInterest calculateInterest)
        {
            SumOfMoney = sumOfMoney;
            InterstRate = interestRate;
            Years = years;
            _calculateInterest = calculateInterest;
        }

        public int SumOfMoney
        {
            get { return _sumOfMoney; }
            protected set
            {
                if(value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Sum of money can not be under 1!");
                }

                _sumOfMoney = value;
            }
        }

        public double InterstRate
        {
            get { return _interestRate; }
            protected set
            {
                if (value < 0.01)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Interest rate can not be under 0.01%!");
                }

                _interestRate = value;
            }
        }

        public int Years
        {
            get { return _years; }
            protected set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Years of return should be at least one!");
                }

                _years = value;
            }
        }

        public double Balance => _calculateInterest(SumOfMoney, InterstRate, Years);
    }
}
