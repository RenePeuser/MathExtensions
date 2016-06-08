namespace MathExtension
{
    public static class ObjectExtensions
    {
        public static bool NotRefEquals(this object source, object target)
        {
            return !RefEquals(source, target);
        }

        public static bool RefEquals(this object source, object target)
        {
            return ReferenceEquals(source, target);
        }

        public static bool IsNull(this object source)
        {
            return source == null;
        }

        public static bool IsNotNull(this object source)
        {
            return !source.IsNull();
        }
    }
}