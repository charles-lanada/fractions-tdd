using System;

namespace FractionsTest
{
    internal class Fraction
    {
        private int integerValue;

        public Fraction(int integerValue)
        {
            this.integerValue = integerValue;
        }

        public Fraction Plus(Fraction that)
        {
            return new Fraction(this.integerValue + that.integerValue);
        }

        public int IntValue()
        {
            return integerValue;
        }
    }
}