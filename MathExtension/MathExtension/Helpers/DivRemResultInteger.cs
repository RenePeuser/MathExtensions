using MathExtension.Base;

namespace MathExtension.Helpers
{
    public class DivRemResultInteger : DivRemResultBase<int>
    {
        public DivRemResultInteger(int quotient, int difference) :
            base(quotient, difference)
        {
        }
    }
}
