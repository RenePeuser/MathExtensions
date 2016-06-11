using System.Windows;

namespace MathExtension.Extensions
{
    public static class MathNegateExtensions
    {
        public static int Negate(this int value)
        {
            return value * -1;
        }

        public static long Negate(this long value)
        {
            return value * -1;
        }

        public static float Negate(this float value)
        {
            return value * -1;
        }

        public static double Negate(this double value)
        {
            return value * -1;
        }

        public static decimal Negate(this decimal value)
        {
            return value * -1;
        }

        public static Point Negate(this Point val1)
        {
            var x = val1.X.Negate();
            var y = val1.Y.Negate();
            return new Point(x, y);
        }
    }
}