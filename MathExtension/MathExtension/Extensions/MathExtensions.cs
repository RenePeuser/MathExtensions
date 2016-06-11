using System;

namespace MathExtension.Extensions
{

    public static class MathExtensions
    {
        public static double IEEERemainder(this double x, double y)
        {
            return Math.IEEERemainder(x, y);
        }

        public static double Log(this double a, double newBase)
        {
            return Math.Log(a, newBase);
        }

        public static long BigMul(this int a, int b)
        {
            return Math.BigMul(a, b);
        }
    }
}