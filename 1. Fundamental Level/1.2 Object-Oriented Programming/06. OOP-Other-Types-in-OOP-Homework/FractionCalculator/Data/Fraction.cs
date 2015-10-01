namespace FractionCalculator.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Fraction
    {
        private long _numerator;
        private long _denomerator;

        public Fraction(long numerator, long denomerator)
        {
            Numerator = numerator;
            Denominator = denomerator;
        }

        public long Numerator
        {
            get { return _numerator; }
            protected set { _numerator = value; }
        }

        public long Denominator
        {
            get { return _denomerator == 0 ? 1 : _denomerator; }
            protected set
            {
                if (value == 0)
                {
                    throw new InvalidOperationException(nameof(value), new Exception("Denominator can not be 0!"));
                }

                _denomerator = value;
            }
        }


        public static Fraction operator +(Fraction first, Fraction second)
        {
            var numerator = first.Numerator * second.Denominator + second.Numerator * first.Denominator;
            var denomerator = first.Denominator * second.Denominator;

            return new Fraction(numerator, denomerator);
        }

        public static Fraction operator -(Fraction first, Fraction second)
        {
            var numerator = first.Numerator * second.Denominator - second.Numerator * first.Denominator;
            var denomerator = first.Denominator * second.Denominator;

            return new Fraction(numerator, denomerator);
        }

        private void Reduce()
        {
            if (Numerator == 0)
            {
                Denominator = 1;
                return;
            }

            var gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator *= -1;
                Denominator *= -1;
            }
        }

        private static long GCD(long firstNumber, long secondNumber)
        {
            if (firstNumber < 0)
            {
                firstNumber = -firstNumber;
            }

            if (secondNumber < 0)
            {
                secondNumber = -secondNumber;
            }

            do
            {
                if (firstNumber < secondNumber)
                {
                    var tmp = firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = tmp;
                }

                firstNumber = firstNumber % secondNumber;
            }
            while (firstNumber != 0);

            return secondNumber;
        }

        public override string ToString()
        {
            Reduce();

            var result = (double) ((double)Numerator / (double)Denominator);

            return result.ToString();
        }
    }
}
