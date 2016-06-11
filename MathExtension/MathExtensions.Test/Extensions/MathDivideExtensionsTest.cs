using System.Windows;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathDivideExtensionsTest
    {
        [TestMethod]
        public void TestDivideWithInt()
        {
            Assert.AreEqual(1, 3.Divide(3));
        }

        [TestMethod]
        public void TestDivideWithUInt()
        {
            const uint val1 = 3;
            const uint expectedValue = 1;

            Assert.AreEqual(expectedValue, val1.Divide(val1));
        }

        [TestMethod]
        public void TestDivideWithLong()
        {
            const long val1 = 3;

            Assert.AreEqual(1, val1.Divide(val1));
        }

        [TestMethod]
        public void TestDivideWithULong()
        {
            const ulong val1 = 3;
            const ulong expectedValue = 1;

            Assert.AreEqual(expectedValue, val1.Divide(val1));
        }

        [TestMethod]
        public void TestDivideWithFloat()
        {
            const float val1 = 3;

            Assert.AreEqual(1, val1.Divide(val1));
        }

        [TestMethod]
        public void TestDivideWithDouble()
        {
            const double val1 = 3.0;

            Assert.AreEqual(1.0, val1.Divide(val1));
        }

        [TestMethod]
        public void TestDivideWithDecimal()
        {
            var val1 = new decimal(3.0);
            var expectedValue = new decimal(1);

            Assert.AreEqual(expectedValue, val1.Divide(val1));
        }

        [TestMethod]
        public void TestDivideWithPoint()
        {
            var val1 = new Point(3.0, 3.0);
            var resultPoint = new Point(1.0, 1.0);

            Assert.AreEqual(resultPoint, val1.Divide(val1));
        }
    }
}