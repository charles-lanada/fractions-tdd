using System;
using System.Diagnostics;

namespace FractionsTest
{
    internal class Fraction
    {
        private readonly int numerator;
        private readonly int denominator;

        public Fraction(int integerValue) : this(integerValue, 1)
        {
        }

        public Fraction(int numerator, int denominator)
        {
            var greatesCommonDivisor = NumberTheory.GreatestCommonDivisor(numerator, denominator);
            this.numerator = numerator / greatesCommonDivisor;
            this.denominator = denominator / greatesCommonDivisor;
        }

        public Fraction Plus(Fraction that)
        {
            if (this.denominator != that.denominator)
            {
                return new Fraction(this.numerator * that.denominator + that.numerator * this.denominator, this.denominator * that.denominator);
            }
            return new Fraction(numerator + that.numerator, denominator);
        }

        public override string ToString()
        {
            return $" {numerator}/{denominator} ";
        }

        public override bool Equals(object other)
        {
            // default implementation of equals is based on identity and uses GetHashCode()
            // based in hashCode or memory location.
            if (other is Fraction)
            {
                var that = other as Fraction;
                return this.numerator == that.numerator && this.denominator == that.denominator;
            }

            return false;
        }

        public override int GetHashCode()
        {
            // hash code is important for hash map search instead of linear search.
            // dive deeper into this. What is hashcode does in C#.
            // return 0 - legal implementation of hashcode.
            // if you return a constant for get hash code, it works but it would be converted to linear search.
            return numerator * 19 + denominator;
        }
    }
}