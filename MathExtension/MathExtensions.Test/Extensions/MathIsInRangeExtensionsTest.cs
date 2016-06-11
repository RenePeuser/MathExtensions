using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathIsInRangeExtensionsTest
    {
        [TestMethod]
        public void TestIsInRangeWithSByteIsTrue()
        {
            sbyte val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithSByteIsFalse()
        {
            sbyte val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithByteIsTrue()
        {
            byte val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithByteIsFalse()
        {
            byte val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithShortIsTrue()
        {
            short val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithShortIsFalse()
        {
            short val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithUShortIsTrue()
        {
            ushort val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithUShortIsFalse()
        {
            ushort val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithIntIsTrue()
        {
            Assert.IsTrue(20.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithIntIsFalse()
        {
            Assert.IsFalse(20.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithUIntIsTrue()
        {
            uint val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithUIntIsFalse()
        {
            uint val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithLongIsTrue()
        {
            long val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithLongIsFalse()
        {
            long val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithULongIsTrue()
        {
            ulong val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithULongIsFalse()
        {
            ulong val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithFloatIsTrue()
        {
            float val = 30;

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithFloatIsFalse()
        {
            float val = 30;

            Assert.IsFalse(val.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithDoubleIsTrue()
        {
            Assert.IsTrue(20.5.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithDoubleIsFalse()
        {
            Assert.IsFalse(20.5.IsInRange(10, 15));
        }

        [TestMethod]
        public void TestIsInRangeWithDecimalIsTrue()
        {
            var val = new decimal(20);

            Assert.IsTrue(val.IsInRange(10, 50));
        }

        [TestMethod]
        public void TestIsInRangeWithDecimalIsFalse()
        {
            var val = new decimal(20);

            Assert.IsFalse(val.IsInRange(10, 15));
        }
    }
}