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

        public Fraction Plus(Fraction fraction)
        {
            return this;
        }

        public int IntValue()
        {
            return integerValue;
        }
    }
}