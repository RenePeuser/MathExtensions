using System.Windows;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathSubtractExtensionsTest
    {
        [TestMethod]
        public void TestSubtractWithInt()
        {
            Assert.AreEqual(0, 3.Subtract(3));
        }

        [TestMethod]
        public void TestSubtractWithUInt()
        {
            const uint val1 = 1;
            const uint expectedValue = 0;

            Assert.AreEqual(expectedValue, val1.Subtract(val1));
        }

        [TestMethod]
        public void TestSubtractWithLong()
        {
            const long val1 = 1;

            Assert.AreEqual(0, val1.Subtract(val1));
        }

        [TestMethod]
        public void TestSubtractWithULong()
        {
            const ulong val1 = 1;
            const ulong expectedValue = 0;

            Assert.AreEqual(expectedValue, val1.Subtract(val1));
        }

        [TestMethod]
        public void TestSubtractWithFloat()
        {
            const float val1 = 1;

            Assert.AreEqual(0, val1.Subtract(val1));
        }

        [TestMethod]
        public void TestSubtractWithDouble()
        {
            const double val1 = 1.1;

            Assert.AreEqual(0, val1.Subtract(val1));
        }

        [TestMethod]
        public void TestSubtractWithDecimal()
        {
            var val1 = new decimal(1.1);

            Assert.AreEqual(0, val1.Subtract(val1));
        }

        [TestMethod]
        public void TestSubtractWithPoint()
        {
            var val1 = new Point(1.1, 1.1);
            var resultPoint = new Point(0, 0);

            Assert.AreEqual(resultPoint, val1.Subtract(val1));
        }
    }
}