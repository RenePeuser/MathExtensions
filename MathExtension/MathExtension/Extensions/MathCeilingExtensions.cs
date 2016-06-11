using System;

namespace MathExtension.Extensions
{
    public static class MathCeilingExtensions
    {
        public static decimal Ceiling(this decimal d)
        {
            return Math.Ceiling(d);
        }

        public static double Ceiling(this double d)
        {
            return Math.Ceiling(d);
        }
    }
}