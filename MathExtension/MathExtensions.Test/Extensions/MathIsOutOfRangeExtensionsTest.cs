using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathIsOutOfRangeExtensionsTest
    {
        [TestMethod]
        public void TestIsOutOfRangeWithSByteIsTrue()
        {
            sbyte val = 0;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithSByteIsFalse()
        {
            sbyte val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithByteIsTrue()
        {
            byte val = 2;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithByteIsFalse()
        {
            byte val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithShortIsTrue()
        {
            short val = 2;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithShortIsFalse()
        {
            short val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithUShortIsTrue()
        {
            ushort val = 2;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithUShortIsFalse()
        {
            ushort val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithIntIsTrue()
        {
            Assert.IsTrue(2.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithIntIsFalse()
        {
            Assert.IsFalse(12.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithUIntIsTrue()
        {
            uint val = 2;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithUIntIsFalse()
        {
            uint val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithLongIsTrue()
        {
            long val = 2;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithLongIsFalse()
        {
            long val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithULongIsTrue()
        {
            ulong val = 2;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithULongIsFalse()
        {
            ulong val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithFloatIsTrue()
        {
            float val = 2;

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithFloatIsFalse()
        {
            float val = 12;

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithDoubleIsTrue()
        {
            Assert.IsTrue(2.5.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithDoubleIsFalse()
        {
            Assert.IsFalse(12.5.IsOutOfRange(10, 15));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithDecimalIsTrue()
        {
            var val = new decimal(2);

            Assert.IsTrue(val.IsOutOfRange(10, 50));
        }

        [TestMethod]
        public void TestIsOutOfRangeWithDecimalIsFalse()
        {
            var val = new decimal(12);

            Assert.IsFalse(val.IsOutOfRange(10, 15));
        }
    }
}