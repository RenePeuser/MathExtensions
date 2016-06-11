namespace MathExtension.Extensions
{
    public static class MathIsInRangeExtensions
    {
        public static bool IsInRange(this sbyte source, sbyte start, sbyte end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this byte source, byte start, byte end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this short source, short start, short end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this ushort source, ushort start, ushort end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this int source, int start, int end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this uint source, uint start, uint end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this long source, long start, long end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this ulong source, ulong start, ulong end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this float source, float start, float end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this double source, double start, double end)
        {
            return source >= start & source <= end;
        }

        public static bool IsInRange(this decimal source, decimal start, decimal end)
        {
            return source >= start & source <= end;
        }
    }
}