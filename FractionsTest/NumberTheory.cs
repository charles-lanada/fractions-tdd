using System;

namespace FractionsTest
{
    public class NumberTheory
    {
        public static int GreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % t;
                a = t;
            }
            return Math.Abs(a);
        }
    }

}