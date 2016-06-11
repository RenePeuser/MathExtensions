using System;

namespace MathExtension.Extensions
{
    public static class MathTruncateExtensions
    {
        public static decimal Truncate(this decimal d)
        {
            return Math.Truncate(d);
        }

        public static double Truncate(this double d)
        {
            return Math.Truncate(d);
        }
    }
}