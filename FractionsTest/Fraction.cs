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
            if(denominator == 0) 
            {
                throw new Exception();
            }

            var denominatorSign = denominator < 0 ? -1 : 1;
            var greatesCommonDivisor = NumberTheory.GreatestCommonDivisor(numerator, denominator) * denominatorSign;
            this.numerator = numerator / greatesCommonDivisor;
            this.denominator = denominator / greatesCommonDivisor;
        }

        public Fraction Plus(Fraction that)
        {
            return new Fraction(this.numerator * that.denominator + that.numerator * this.denominator, this.denominator * that.denominator);
        }

        public Fraction Times(Fraction that)
        {
            return new Fraction(this.numerator * that.numerator, this.denominator * that.denominator);
        }

        public Fraction Minus(Fraction that)
        {
            return new Fraction(this.numerator - that.numerator);
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