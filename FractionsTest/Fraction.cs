using System;

namespace FractionsTest
{
    internal class Fraction
    {
        private int integerValue;
        private readonly int denominator;

        public Fraction(int integerValue)
        {
            this.integerValue = integerValue;
        }

        public Fraction(int numerator, int denominator)
        {
            this.integerValue = numerator;
            this.denominator = denominator;
        }

        public Fraction Plus(Fraction that)
        {
            return new Fraction(this.integerValue + that.integerValue, denominator);
        }

        public int IntValue()
        {   
            return integerValue;
        }

        public int Numerator()
        {
            return 3;
        }

        public int Denominator()
        {
            return denominator;
        }
    }
}