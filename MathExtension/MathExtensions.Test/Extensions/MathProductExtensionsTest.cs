using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathProductExtensionsTest
    {
        [TestMethod]
        public void TestProductWithInt()
        {
            var source = new[] { 3, 3 };
            Assert.AreEqual(9, source.Product());
        }

        [TestMethod]
        public void TestProductWithLong()
        {
            var source = new long[] { 3, 3 };
            Assert.AreEqual(9, source.Product());
        }

        [TestMethod]
        public void TestProductWithFloat()
        {
            var source = new float[] { 3, 3 };
            Assert.AreEqual(9, source.Product());
        }

        [TestMethod]
        public void TestProductWithDouble()
        {
            var source = new[] { 3.0, 3.0 };
            Assert.AreEqual(9.0, source.Product());
        }

        [TestMethod]
        public void TestProductWithDecimal()
        {
            var source = new[] { new decimal(3), new decimal(3) };
            Assert.AreEqual(9, source.Product());
        }
    }
}