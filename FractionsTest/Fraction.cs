using System;

namespace FractionsTest
{
    internal class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int integerValue): this(integerValue, 1)
        {
        }

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Plus(Fraction that)
        {
            return new Fraction(numerator + that.numerator , denominator);
        }

        public int IntValue()
        {   
            return numerator;
        }

        public int GetNumerator()
        {
            return numerator;
        }

        public int GetDenominator()
        {
            return denominator;
        }
    }
}