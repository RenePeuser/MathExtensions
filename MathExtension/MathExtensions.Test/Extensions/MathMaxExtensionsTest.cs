using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathMaxExtensionsTest
    {
        [TestMethod]
        public void TestMaxWithSByte()
        {
            const sbyte val1 = 5;
            const sbyte val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithByte()
        {
            byte val1 = 5;
            byte val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithShort()
        {
            short val1 = 5;
            short val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithUShort()
        {
            ushort val1 = 5;
            ushort val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithInt()
        {
            int val1 = 5;
            int val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithUInt()
        {
            uint val1 = 5;
            uint val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithLong()
        {
            long val1 = 5;
            long val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithULong()
        {
            ulong val1 = 5;
            ulong val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithFloat()
        {
            float val1 = 5;
            float val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithDouble()
        {
            double val1 = 5;
            double val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }

        [TestMethod]
        public void TestMaxWithDecimal()
        {
            decimal val1 = 5;
            decimal val2 = 6;

            Assert.AreEqual(val2, val1.Max(val2));
        }
    }
}