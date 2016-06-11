using System;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{

    [TestClass]
    public class MathExtensionsTest
    {
        [TestMethod]
        public void TestIEEERemainde()
        {
            var val1 = 5.5;
            var val2 = 6.6;

            var result1 = Math.IEEERemainder(val1, val2);
            var result2 = val1.IEEERemainder(val2);

            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void TestLog()
        {
            var val1 = 5.5;
            var val2 = 6.6;

            var result1 = Math.Log(val1, val2);
            var result2 = val1.Log(val2);

            Assert.AreEqual(result1, result2);
        }

        [TestMethod]
        public void TestBigMul()
        {
            var val1 = 10;
            var val2 = 5;

            var result1 = Math.BigMul(val1, val2);
            var result2 = val1.BigMul(val2);

            Assert.AreEqual(result1, result2);
        }
    }
}