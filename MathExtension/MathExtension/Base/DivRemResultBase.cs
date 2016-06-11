namespace MathExtension.Base
{
    public abstract class DivRemResultBase<T>
    {
        protected DivRemResultBase(T quotient, T difference)
        {
            Quotient = quotient;
            Difference = difference;
        }

        public T Quotient { get; }
        public T Difference { get; }
    }
}
