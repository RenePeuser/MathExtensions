using System;

namespace MathExtension.Extensions
{
    public static class MathFloorExtensions
    {
        public static decimal Floor(this decimal d)
        {
            return Math.Floor(d);
        }
        public static double Floor(this double d)
        {
            return Math.Floor(d);
        }
    }
}