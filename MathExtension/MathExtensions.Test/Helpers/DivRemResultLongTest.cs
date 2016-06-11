using MathExtension.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Helpers
{
    [TestClass]
    public class DivRemResultLongTest
    {
        private DivRemResultLong _divRemResultLong;
        private long _quotient = 42;
        private long _difference;

        [TestInitialize]
        public void Init()
        {
            _difference = 2;
            _divRemResultLong = new DivRemResultLong(_quotient, _difference);
        }

        [TestMethod]
        public void QuotientHaveToBeExpectedValue()
        {
            Assert.AreEqual(_quotient, _divRemResultLong.Quotient);
        }

        [TestMethod]
        public void DifferenceHaveToBeExpectedValue()
        {
            Assert.AreEqual(_difference, _divRemResultLong.Difference);
        }
    }
}
