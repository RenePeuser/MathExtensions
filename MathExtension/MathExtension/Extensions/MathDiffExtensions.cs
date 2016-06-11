using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Extensions;

namespace MathExtension.Extensions
{
    public static class MathDiffExtensions
    {
        public static int Diff(this IEnumerable<int> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product -= values[i];
            }
            return product;
        }

        public static long Diff(this IEnumerable<long> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product -= values[i];
            }
            return product;
        }

        public static float Diff(this IEnumerable<float> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product -= values[i];
            }
            return product;
        }

        public static double Diff(this IEnumerable<double> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product -= values[i];
            }
            return product;

        }

        public static decimal Diff(this IEnumerable<decimal> source)
        {
            Contract.Requires(source.IsNotNull());

            var values = source.ToList();
            var product = values.FirstOrDefault();

            for (var i = 1; i < values.Count; i++)
            {
                product -= values[i];
            }
            return product;
        }
    }
}