using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Extensions;

namespace MathExtension.Extensions
{
    public static class MathQuotientExtensions
    {
        public static int Quotient(this IEnumerable<int> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product /= values[i];
            }
            return product;
        }

        public static long Quotient(this IEnumerable<long> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product /= values[i];
            }
            return product;
        }

        public static float Quotient(this IEnumerable<float> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product /= values[i];
            }
            return product;
        }

        public static double Quotient(this IEnumerable<double> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product /= values[i];
            }
            return product;

        }

        public static decimal Quotient(this IEnumerable<decimal> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product /= values[i];
            }
            return product;
        }
    }
}