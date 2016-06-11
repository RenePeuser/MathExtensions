using System.Windows;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathMultiplyExtensionsTest
    {
        [TestMethod]
        public void TestMultiplyWithInt()
        {
            Assert.AreEqual(9, 3.Multiply(3));
        }

        [TestMethod]
        public void TestMultiplyWithUInt()
        {
            const uint val1 = 3;
            const uint expectedValue = 9;

            Assert.AreEqual(expectedValue, val1.Multiply(val1));
        }

        [TestMethod]
        public void TestMultiplyWithLong()
        {
            const long val1 = 3;

            Assert.AreEqual(9, val1.Multiply(val1));
        }

        [TestMethod]
        public void TestMultiplyWithULong()
        {
            const ulong val1 = 3;
            const ulong expectedValue = 9;

            Assert.AreEqual(expectedValue, val1.Multiply(val1));
        }

        [TestMethod]
        public void TestMultiplyWithFloat()
        {
            const float val1 = 3;

            Assert.AreEqual(9, val1.Multiply(val1));
        }

        [TestMethod]
        public void TestMultiplyWithDouble()
        {
            const double val1 = 3.0;

            Assert.AreEqual(9, val1.Multiply(val1));
        }

        [TestMethod]
        public void TestMultiplyWithDecimal()
        {
            var val1 = new decimal(3);

            Assert.AreEqual(9, val1.Multiply(val1));
        }

        [TestMethod]
        public void TestMultiplyWithPoint()
        {
            var val1 = new Point(3, 3);
            var resultPoint = new Point(9, 9);

            Assert.AreEqual(resultPoint, val1.Multiply(val1));
        }
    }
}