using NUnit.Framework;

namespace FractionsTest
{
    public class ReduceFractionTests
    {
        [Test]
        public void Already_in_lowest_terms()
        {
            Assert.AreEqual(new Fraction(3, 4), new Fraction(3, 4));
            // We've already tested this in FractionEqualsTests
        }  
        
        [Test]
        public void Reduce_to_not_whole_number()
        {
            Assert.AreEqual(new Fraction(6, 8), new Fraction(3, 4));
        }  

        [Test]
        public void Reduce_to_whole_number()
        {
            Assert.AreEqual(new Fraction(6), new Fraction(24, 4));
        }
        
        [Test]
        public void Reduce_to_zero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0, 12312));
        }
        
    }

}