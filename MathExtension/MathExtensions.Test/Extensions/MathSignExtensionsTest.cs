using System;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathSignExtensionsWithSByteTest
    {
        [TestMethod]
        public void TestSignWithZeroValue()
        {
            sbyte val = 0;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithNegativeValue()
        {
            sbyte val = -5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithPositiveValue()
        {
            sbyte val = 5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }
    }

    [TestClass]
    public class MathSignExtensionsWithShortTest
    {
        [TestMethod]
        public void TestSignWithZeroValue()
        {
            short val = 0;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithNegativeValue()
        {
            short val = -5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithPositiveValue()
        {
            short val = 5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }
    }

    [TestClass]
    public class MathSignExtensionsWithIntTest
    {
        [TestMethod]
        public void TestSignWithZeroValue()
        {
            int val = 0;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithNegativeValue()
        {
            int val = -5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithPositiveValue()
        {
            int val = 5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }
    }

    [TestClass]
    public class MathSignExtensionsWithLongTest
    {
        [TestMethod]
        public void TestSignWithZeroValue()
        {
            long val = 0;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithNegativeValue()
        {
            long val = -5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithPositiveValue()
        {
            long val = 5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }
    }

    [TestClass]
    public class MathSignExtensionsWithFloatTest
    {
        [TestMethod]
        public void TestSignWithZeroValue()
        {
            float val = 0;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithNegativeValue()
        {
            float val = -5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithPositiveValue()
        {
            float val = 5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }
    }

    [TestClass]
    public class MathSignExtensionsWithDoubleTest
    {
        [TestMethod]
        public void TestSignWithZeroValue()
        {
            double val = 0;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithNegativeValue()
        {
            double val = -5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithPositiveValue()
        {
            double val = 5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }
    }

    [TestClass]
    public class MathSignExtensionsWithDecimalTest
    {
        [TestMethod]
        public void TestSignWithZeroValue()
        {
            decimal val = 0;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithNegativeValue()
        {
            decimal val = -5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }

        [TestMethod]
        public void TestSignWithPositiveValue()
        {
            decimal val = 5;

            Assert.AreEqual(Math.Sign(val), val.Sign());
        }
    }
}