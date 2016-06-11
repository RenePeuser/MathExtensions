using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathQuotientExtensionsTest
    {
        [TestMethod]
        public void TestQuotientWithInt()
        {
            var source = new[] { 9, 3 };
            Assert.AreEqual(3, source.Quotient());
        }

        [TestMethod]
        public void TestQuotientWithLong()
        {
            var source = new long[] { 9, 3 };
            Assert.AreEqual(3, source.Quotient());
        }

        [TestMethod]
        public void TestQuotientWithFloat()
        {
            var source = new float[] { 9, 3 };
            Assert.AreEqual(3, source.Quotient());
        }

        [TestMethod]
        public void TestQuotientWithDouble()
        {
            var source = new[] { 9.0, 3.0 };
            Assert.AreEqual(3.0, source.Quotient());
        }

        [TestMethod]
        public void TestQuotientWithDecimal()
        {
            var source = new[] { new decimal(9), new decimal(3) };
            Assert.AreEqual(3, source.Quotient());
        }
    }
}