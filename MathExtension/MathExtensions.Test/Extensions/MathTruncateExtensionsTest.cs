using System;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathTruncateExtensionsTest
    {
        [TestMethod]
        public void TestTruncateWithDecimal()
        {
            var val = new decimal(3.16574339);

            Assert.AreEqual(Math.Truncate(val), val.Truncate());
        }

        [TestMethod]
        public void TestTruncateWithDouble()
        {
            var val = 3.16574339;

            Assert.AreEqual(Math.Truncate(val), val.Truncate());
        }
    }
}