using MathExtension.Base;

namespace MathExtension.Helpers
{
    public class DivRemResultLong : DivRemResultBase<long>
    {
        public DivRemResultLong(long quotient, long difference) :
            base(quotient, difference)
        {
        }
    }
}
