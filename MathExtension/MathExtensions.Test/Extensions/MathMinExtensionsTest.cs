using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathMinExtensionsTest
    {
        [TestMethod]
        public void TestMinWithSByte()
        {
            const sbyte val1 = 5;
            const sbyte val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithByte()
        {
            byte val1 = 5;
            byte val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithShort()
        {
            short val1 = 5;
            short val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithUShort()
        {
            ushort val1 = 5;
            ushort val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithInt()
        {
            int val1 = 5;
            int val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithUInt()
        {
            uint val1 = 5;
            uint val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithLong()
        {
            long val1 = 5;
            long val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithULong()
        {
            ulong val1 = 5;
            ulong val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithFloat()
        {
            float val1 = 5;
            float val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithDouble()
        {
            double val1 = 5;
            double val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }

        [TestMethod]
        public void TestMinWithDecimal()
        {
            decimal val1 = 5;
            decimal val2 = 6;

            Assert.AreEqual(val1, val1.Min(val2));
        }
    }
}