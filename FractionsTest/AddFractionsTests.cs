using NUnit.Framework;
using Fractions;
using NUnit.Framework.Constraints;

namespace FractionsTest
{
    public class AddFractionsTests
    {
        [Test]
        public void When_adding_zeroes()
        {
            var sum = new Fraction(0).Plus(new Fraction(0));
            Assert.That(sum.IntValue(), Is.EqualTo(0));
        }

        [Test]
        public void When_adding_NonZero_plus_Zero()
        {
            var sum = new Fraction(3).Plus(new Fraction(0));
            Assert.That(sum.IntValue(), Is.EqualTo(3));
        } 
        
        [Test]
        public void When_adding_Zero_plus_NonZero()
        {
            var sum = new Fraction(0).Plus(new Fraction(3));
            Assert.That(sum.IntValue(), Is.EqualTo(3));
        }   

        [Test]
        public void When_adding_NonNegative_NonZero()
        {
            var sum = new Fraction(4).Plus(new Fraction(3));
            Assert.That(sum.IntValue(), Is.EqualTo(7));
        }
        
        [Test]
        public void When_adding_Negative_NonNegative()
        {
            var sum = new Fraction(-3).Plus(new Fraction(1));
            Assert.That(sum.IntValue(), Is.EqualTo(-2));
        }

        // 1/5 + 2/5 = 3/5
        [Test]
        public void Non_trivial_denominators_but_common_denominators()
        {
            Fraction sum = new Fraction(1, 5).Plus(new Fraction(2, 5));
            Assert.That(sum, Is.EqualTo(new Fraction(3,5)));
        }


    }
}