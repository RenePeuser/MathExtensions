using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathFloorExtensionsTest
    {
        [TestMethod]
        public void TestFloorWithDecimal()
        {
            var val = new decimal(3.3);
            Assert.AreEqual(3, val.Floor());
        }

        [TestMethod]
        public void TestFloorWithDouble()
        {
            var val = 3.3;
            Assert.AreEqual(3, val.Floor());
        }
    }
}