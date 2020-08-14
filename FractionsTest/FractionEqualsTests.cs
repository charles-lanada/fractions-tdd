using NUnit.Framework;

namespace FractionsTest
{
    public class FractionsEqualsTests
    {
        [TestCase(3, 5, 3, 5, true)]
        [TestCase(3, 7, 3, 6, false)]
        [TestCase(2, 5, 1, 5, false)]
        public void When_doing_equals_for_fraction(int numerator1, int denominator1, int numerator2, int denominator2, bool expectedResult)
        {
            var actualResult = new Fraction(numerator1, denominator1).Equals(new Fraction(numerator2, denominator2));
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Whole_number_equals_to_same_fraction()
        {
            var result = new Fraction(5).Equals(new Fraction(5, 1));
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void Whole_number_not_equal_to_different_whole_number()
        {
            var result = new Fraction(3).Equals(new Fraction(5));
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void When_having_negatives()
        {
            var result = new Fraction(1, 2).Equals(new Fraction(-1, -2));
            Assert.True(result);

            var result2 = new Fraction(-1, 2).Equals(new Fraction(1, -2));
            Assert.True(result2);

            var result3 = new Fraction(-1, 2).Equals(new Fraction(-1, 2));
            Assert.True(result3);
        }
        
    }



}