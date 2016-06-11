using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathAbsExtensionsTest
    {
        [TestMethod]
        public void TestAbsToSByte()
        {
            const sbyte source = -42;
            Assert.AreEqual(42, source.Abs());
        }

        [TestMethod]
        public void TestAbsToShort()
        {
            const short source = -42;
            Assert.AreEqual(42, source.Abs());
        }

        [TestMethod]
        public void TestAbsToInt()
        {
            const int source = -42;
            Assert.AreEqual(42, source.Abs());
        }

        [TestMethod]
        public void TestAbsToLong()
        {
            const long source = -42;
            Assert.AreEqual(42, source.Abs());
        }

        [TestMethod]
        public void TestAbsToDecimal()
        {
            var source = new decimal(-42.12);
            var expectedValue = new decimal(42.12);

            Assert.AreEqual(expectedValue, source.Abs());
        }
    }
}