using NUnit.Framework;
using Fractions;

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
    }
}