using MathExtension.Extensions;
using MathExtension.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{

    [TestClass]
    public class MathDivRemExtensionsIntegerTest
    {
        private DivRemResultInteger _divRemResultInteger;

        [TestInitialize]
        public void Init()
        {
            _divRemResultInteger = 5.DivRem(6);
        }

        public void TestQuotientResult()
        {
            Assert.AreEqual(0, _divRemResultInteger.Quotient);
        }

        public void TestDifferenceResult()
        {
            Assert.AreEqual(1, _divRemResultInteger.Difference);
        }
    }

    [TestClass]
    public class MathDivRemExtensionsLongTest
    {
        private DivRemResultLong _divRemResultLong;

        [TestInitialize]
        public void Init()
        {
            const long val1 = 5;
            const long val2 = 6;

            _divRemResultLong = val1.DivRem(val2);
        }

        public void TestQuotientResult()
        {
            Assert.AreEqual(0, _divRemResultLong.Quotient);
        }

        public void TestDifferenceResult()
        {
            Assert.AreEqual(1, _divRemResultLong.Difference);
        }
    }
}