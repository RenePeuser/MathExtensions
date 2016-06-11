using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathDiffExtensionsTest
    {
        [TestMethod]
        public void TestDiffWithInt()
        {
            var source = new[] { 9, 3, 3 };
            Assert.AreEqual(3, source.Diff());
        }

        [TestMethod]
        public void TestDiffWithLong()
        {
            var source = new long[] { 9, 3, 3 };
            Assert.AreEqual(3, source.Diff());
        }

        [TestMethod]
        public void TestDiffWithFloat()
        {
            var source = new float[] { 9, 3, 3 };
            Assert.AreEqual(3, source.Diff());
        }

        [TestMethod]
        public void TestDiffWithDouble()
        {
            var source = new double[] { 9, 3, 3 };
            double expectedValue = 3;

            Assert.AreEqual(expectedValue, source.Diff());
        }

        [TestMethod]
        public void TestDiffWithDecimal()
        {
            var source = new[] { new decimal(9.3), new decimal(3.1), new decimal(3.1) };
            var expectedValue = new decimal(3.1);

            Assert.AreEqual(expectedValue, source.Diff());
        }
    }
}