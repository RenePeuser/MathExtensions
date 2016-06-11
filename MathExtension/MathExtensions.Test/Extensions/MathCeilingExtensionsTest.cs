using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathCeilingExtensionsTest
    {
        [TestMethod]
        public void TestCeilingWithDecimal()
        {
            var val = new decimal(3.3);
            Assert.AreEqual(4, val.Ceiling());
        }

        [TestMethod]
        public void TestCeilingWithDouble()
        {
            var val = 3.3;
            Assert.AreEqual(4, val.Ceiling());
        }
    }
}