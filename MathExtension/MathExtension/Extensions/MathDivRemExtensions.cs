using System;
using MathExtension.Helpers;

namespace MathExtension.Extensions
{

    public static class MathDivRemExtensions
    {
        public static DivRemResultInteger DivRem(this int a, int b)
        {
            int difference;
            var quotient = Math.DivRem(a, b, out difference);
            return new DivRemResultInteger(quotient, difference);

        }

        public static DivRemResultLong DivRem(this long a, long b)
        {
            long difference;
            var quotient = Math.DivRem(a, b, out difference);
            return new DivRemResultLong(quotient, difference);
        }
    }
}