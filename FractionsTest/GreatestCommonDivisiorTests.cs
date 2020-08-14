using NUnit.Framework;

namespace FractionsTest
{
    public class GreatestCommonDivisorTests
    {
        [TestCase(1,1,1)]
        [TestCase(2,2,2)]
        [TestCase(-1,-1,1)]
        public void Reflexive_a_number_for_itself(int numerator, int denomator, int expectedResult)
        {
            Assert.AreEqual(expectedResult, NumberTheory.GreatestCommonDivisor(numerator, denomator));
        }

        [TestCase(2, 3, 1)]
        [TestCase(4, 7, 1)]
        [TestCase(-2, -3, 1)]
        public void Relatively_prime(int numerator, int denomator, int expectedResult)
        {
            Assert.AreEqual(expectedResult, NumberTheory.GreatestCommonDivisor(numerator, denomator));
        }   
        
        [TestCase(5, 1, 1)]
        [TestCase(7, 21, 7)]
        [TestCase(32, 4, 4)]
        public void One_is_the_multiple_of_the_other(int numerator, int denomator, int expectedResult)
        {
            Assert.AreEqual(expectedResult, NumberTheory.GreatestCommonDivisor(numerator, denomator));
        }   
        
        [TestCase(6, 8, 2)]
        [TestCase(49, 315, 7)]
        public void Common_factor(int numerator, int denomator, int expectedResult)
        {
            Assert.AreEqual(expectedResult, NumberTheory.GreatestCommonDivisor(numerator, denomator));
        }

        [TestCase(-24, -28, 4)]
        [TestCase(-49, -315, 7)]
        public void Having_some_negatives_then_if_it_happens_it_should_be_positive(int numerator, int denomator, int expectedResult)
        {
            Assert.AreEqual(expectedResult, NumberTheory.GreatestCommonDivisor(numerator, denomator));
        }
    }

}