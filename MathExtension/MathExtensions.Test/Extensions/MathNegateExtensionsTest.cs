using System.Windows;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathNegateExtensionsTest
    {
        [TestMethod]
        public void TestNegateToIntOnPositiveValue()
        {
            const int source = 42;
            Assert.AreEqual(-42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToIntOnNegativeValue()
        {
            const int source = -42;
            Assert.AreEqual(42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToLongOnPositiveValue()
        {
            const long source = 42;
            Assert.AreEqual(-42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToLongOnNegativeValue()
        {
            const long source = -42;
            Assert.AreEqual(42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToFloatOnPositiveValue()
        {
            const float source = 42;
            Assert.AreEqual(-42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToFloatOnNegativeValue()
        {
            const float source = -42;
            Assert.AreEqual(42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToDoubleOnPositiveValue()
        {
            const double source = 42;
            Assert.AreEqual(-42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToDoubleOnNegativeValue()
        {
            const double source = -42;
            Assert.AreEqual(42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToDecimalOnPositiveValue()
        {
            const decimal source = 42;
            Assert.AreEqual(-42, source.Negate());
        }

        [TestMethod]
        public void TestNegateToDecimalOnNegativeValue()
        {
            const decimal source = -42;
            Assert.AreEqual(42, source.Negate());
        }


        [TestMethod]
        public void TestNegateToPointOnPositiveValue()
        {
            var point = new Point(3, 3);
            var expectedPoint = new Point(-3, -3);

            Assert.AreEqual(expectedPoint, point.Negate());
        }

        [TestMethod]
        public void TestNegateToPointOnNegativeValue()
        {
            var point = new Point(-3, -3);
            var expectedPoint = new Point(3, 3);

            Assert.AreEqual(expectedPoint, point.Negate());
        }
    }
}