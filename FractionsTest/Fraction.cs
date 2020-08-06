﻿using System;

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
            if (that.integerValue > 0) return that;
            return this;
        }

        public int IntValue()
        {
            return integerValue;
        }
    }
}