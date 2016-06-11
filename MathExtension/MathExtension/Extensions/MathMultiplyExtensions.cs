using System.Windows;

namespace MathExtension.Extensions
{
    public static class MathMultiplyExtensions
    {
        public static int Multiply(this int val1, int val2)
        {
            return val1 * val2;
        }

        public static uint Multiply(this uint val1, uint val2)
        {
            return val1 * val2;
        }

        public static long Multiply(this long val1, long val2)
        {
            return val1 * val2;
        }

        public static ulong Multiply(this ulong val1, ulong val2)
        {
            return val1 * val2;
        }

        public static float Multiply(this float val1, float val2)
        {
            return val1 * val2;
        }

        public static double Multiply(this double val1, double val2)
        {
            return val1 * val2;
        }

        public static decimal Multiply(this decimal val1, decimal val2)
        {
            return val1 * val2;
        }

        public static Point Multiply(this Point val1, Point val2)
        {
            var x = val1.X.Multiply(val2.X);
            var y = val1.Y.Multiply(val2.Y);
            return new Point(x, y);
        }
    }
}