namespace MathExtension.Extensions
{
    public static class MathIsOutOfRangeExtensions
    {
        public static bool IsOutOfRange(this sbyte source, sbyte start, sbyte end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this byte source, byte start, byte end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this short source, short start, short end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this ushort source, ushort start, ushort end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this int source, int start, int end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this uint source, uint start, uint end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this long source, long start, long end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this ulong source, ulong start, ulong end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this float source, float start, float end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this double source, double start, double end)
        {
            return !source.IsInRange(start, end);
        }

        public static bool IsOutOfRange(this decimal source, decimal start, decimal end)
        {
            return !source.IsInRange(start, end);
        }
    }
}