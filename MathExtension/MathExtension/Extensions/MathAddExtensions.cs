using System.Windows;

namespace MathExtension.Extensions
{
    public static class MathAddExtensions
    {
        public static int Add(this int val1, int val2)
        {
            return val1 + val2;
        }

        public static uint Add(this uint val1, uint val2)
        {
            return val1 + val2;
        }

        public static long Add(this long val1, long val2)
        {
            return val1 + val2;
        }

        public static ulong Add(this ulong val1, ulong val2)
        {
            return val1 + val2;
        }

        public static float Add(this float val1, float val2)
        {
            return val1 + val2;
        }

        public static double Add(this double val1, double val2)
        {
            return val1 + val2;
        }

        public static decimal Add(this decimal val1, decimal val2)
        {
            return val1 + val2;
        }

        public static Point Add(this Point val1, Point val2)
        {
            var x = val1.X.Add(val2.X);
            var y = val1.Y.Add(val2.Y);
            return new Point(x, y);
        }
    }
}