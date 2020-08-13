using NUnit.Framework;
using System;

namespace FractionsTest
{
    public class GreatestCommonDivisorTests
    {
        [Test]
        public void One_and_one()
        {
            Assert.AreEqual(1, gcd(1, 1));
        }

        private double gcd(int a, int b)
        {
            while(b != 0)
            {
                var t = b;
                b = a % t;
                a = t;
            }
            return a;
        }
    }

}