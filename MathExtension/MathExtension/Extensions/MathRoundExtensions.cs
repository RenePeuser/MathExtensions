using System;

namespace MathExtension.Extensions
{
    public static class MathRoundExtensions
    {
        public static double Round(this double value, int digits)
        {
            return Math.Round(value, digits);
        }

        public static double Round(this double value, MidpointRounding mode)
        {
            return Math.Round(value, 0, mode);
        }

        public static double Round(this double value, int digits, MidpointRounding mode)
        {
            return Math.Round(value, digits, mode);
        }
    }
}