using MathExtension.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Helpers
{
    [TestClass]
    public class DivRemResultIntegerTest
    {
        private DivRemResultInteger _divRemResultInteger;
        private int _quotient = 42;
        private int _difference;

        [TestInitialize]
        public void Init()
        {
            _difference = 2;
            _divRemResultInteger = new DivRemResultInteger(_quotient, _difference);
        }

        [TestMethod]
        public void QuotientHaveToBeExpectedValue()
        {
            Assert.AreEqual(_quotient, _divRemResultInteger.Quotient);
        }

        [TestMethod]
        public void DifferenceHaveToBeExpectedValue()
        {
            Assert.AreEqual(_difference, _divRemResultInteger.Difference);
        }
    }
}
