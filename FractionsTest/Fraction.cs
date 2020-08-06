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
            return fraction;
        }

        public int IntValue()
        {
            return 0;
        }
    }
}