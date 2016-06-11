using System.Windows;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathAddExtensionsTest
    {
        [TestMethod]
        public void TestAddWithInt()
        {
            Assert.AreEqual(2, 1.Add(1));
        }

        [TestMethod]
        public void TestAddWithUInt()
        {
            const uint val1 = 1;
            const uint expectedValue = 2;

            Assert.AreEqual(expectedValue, val1.Add(val1));
        }

        [TestMethod]
        public void TestAddWithLong()
        {
            const long val1 = 1;

            Assert.AreEqual(2, val1.Add(val1));
        }

        [TestMethod]
        public void TestAddWithULong()
        {
            const ulong val1 = 1;
            const ulong expectedValue = 2;

            Assert.AreEqual(expectedValue, val1.Add(val1));
        }

        [TestMethod]
        public void TestAddWithFloat()
        {
            const float val1 = 1;

            Assert.AreEqual(2, val1.Add(val1));
        }

        [TestMethod]
        public void TestAddWithDouble()
        {
            const double val1 = 1.1;

            Assert.AreEqual(2.2, val1.Add(val1));
        }

        [TestMethod]
        public void TestAddWithDecimal()
        {
            var val1 = new decimal(1.1);
            var expectedValue = new decimal(2.2);

            Assert.AreEqual(expectedValue, val1.Add(val1));
        }

        [TestMethod]
        public void TestAddWithPoint()
        {
            var val1 = new Point(1.1, 1.1);
            var resultPoint = new Point(2.2, 2.2);

            Assert.AreEqual(resultPoint, val1.Add(val1));
        }
    }
}