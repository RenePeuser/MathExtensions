using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Extensions;

namespace MathExtension.Extensions
{
    public static class MathProductExtensions
    {
        public static int Product(this IEnumerable<int> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product *= values[i];
            }
            return product;
        }

        public static long Product(this IEnumerable<long> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product *= values[i];
            }
            return product;
        }

        public static float Product(this IEnumerable<float> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product *= values[i];
            }
            return product;
        }

        public static double Product(this IEnumerable<double> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product *= values[i];
            }
            return product;

        }

        public static decimal Product(this IEnumerable<decimal> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product *= values[i];
            }
            return product;
        }
    }
}