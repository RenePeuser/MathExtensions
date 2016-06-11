using System.Windows;

namespace MathExtension.Extensions
{
    public static class MathSubtractExtensions
    {
        public static int Subtract(this int val1, int val2)
        {
            return val1 - val2;
        }

        public static uint Subtract(this uint val1, uint val2)
        {
            return val1 - val2;
        }

        public static long Subtract(this long val1, long val2)
        {
            return val1 - val2;
        }

        public static ulong Subtract(this ulong val1, ulong val2)
        {
            return val1 - val2;
        }

        public static float Subtract(this float val1, float val2)
        {
            return val1 - val2;
        }

        public static double Subtract(this double val1, double val2)
        {
            return val1 - val2;
        }

        public static decimal Subtract(this decimal val1, decimal val2)
        {
            return val1 - val2;
        }

        public static Point Subtract(this Point val1, Point val2)
        {
            var x = val1.X.Subtract(val2.X);
            var y = val1.Y.Subtract(val2.Y);
            return new Point(x, y);
        }
    }
}