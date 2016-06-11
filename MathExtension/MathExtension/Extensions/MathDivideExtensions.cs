using System.Diagnostics.Contracts;
using System.Windows;
using Extensions;

namespace MathExtension.Extensions
{
    public static class MathDivideExtensions
    {
        public static int Divide(this int val1, int val2)
        {
            Contract.Requires(val2 != 0);
            return val1 / val2;
        }

        public static uint Divide(this uint val1, uint val2)
        {
            Contract.Requires(val2 != 0);
            return val1 / val2;
        }

        public static long Divide(this long val1, long val2)
        {
            Contract.Requires(val2 != 0);
            return val1 / val2;
        }

        public static ulong Divide(this ulong val1, ulong val2)
        {
            Contract.Requires(val2 != 0);
            return val1 / val2;
        }

        public static float Divide(this float val1, float val2)
        {
            Contract.Requires(val2.NotRefEquals(0));
            return val1 / val2;
        }

        public static double Divide(this double val1, double val2)
        {
            Contract.Requires(val2.NotRefEquals(0));
            return val1 / val2;
        }

        public static decimal Divide(this decimal val1, decimal val2)
        {
            Contract.Requires(val2 != 0);
            return val1 / val2;
        }

        public static Point Divide(this Point val1, Point val2)
        {
            var x = val1.X.Divide(val2.X);
            var y = val1.Y.Divide(val2.Y);
            return new Point(x, y);
        }
    }
}