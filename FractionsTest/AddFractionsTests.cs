using NUnit.Framework;

namespace FractionsTest
{
    public class AddFractionsTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(3, 0, 3)]
        [TestCase(0, 3, 3)]
        [TestCase(4, 3, 7)]
        [TestCase(-3, 1, -2)]
        public void When_adding_whole_numbers(int num1, int num2, int result)
        {
            var sum = new Fraction(num1).Plus(new Fraction(num2));
            Assert.That(sum, Is.EqualTo(new Fraction(result)));
        }

        // 1/5 + 2/5 = 3/5
        [Test]
        public void Non_trivial_denominators_but_common_denominators()
        {
            Fraction sum = new Fraction(1, 5).Plus(new Fraction(2, 5));
            Assert.That(sum, Is.EqualTo(new Fraction(3,5)));
        }

        // 1/2 + 1/3 = 5/6
        [Test]
        public void Different_denominators_without_reducing_the_results()
        {
            var sum = new Fraction(1, 2).Plus(new Fraction(1, 3));
            Assert.That(sum, Is.EqualTo(new Fraction(5, 6)));
        }

        [Test]
        public void Reduce_result_to_whole_number()
        {
            var sum = new Fraction(5, 10).Plus(new Fraction(5, 10));
            Assert.That(sum, Is.EqualTo(new Fraction(1)));
        }

        [Test]
        public void One_denominator_is_a_multiple_of_the_other()
        {
            var sum = new Fraction(3, 4).Plus(new Fraction(5, 8));
            Assert.That(sum, Is.EqualTo(new Fraction(11,8)));
        }

        // this part unit testing.
        // common factor in denominators
        // reduce result even when denominators are the same
        // negative fractions and reducing
        // negative signes everywhere (ignored)
    }
}