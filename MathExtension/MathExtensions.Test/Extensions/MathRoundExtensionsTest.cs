using System;
using MathExtension.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Extensions
{
    [TestClass]
    public class MathRoundExtensionsWithDoubleTest
    {
        private const double Value = 3.14769;

        [TestMethod]
        public void TestRountWithDoubleWithDigitsInfo()
        {
            var resultNew = Value.Round(2);
            var resultOrg = Math.Round(Value, 2);

            Assert.AreEqual(resultOrg, resultNew);
        }

        [TestMethod]
        public void TestRountWithDoubleAndMidpointRounding()
        {
            var resultNew = Value.Round(MidpointRounding.ToEven);
            var resultOrg = Math.Round(Value, MidpointRounding.ToEven);

            Assert.AreEqual(resultOrg, resultNew);
        }

        [TestMethod]
        public void TestRountWithDoubleDigitsAndMidpointRounding()
        {
            var resultNew = Value.Round(2, MidpointRounding.ToEven);
            var resultOrg = Math.Round(Value, 2, MidpointRounding.ToEven);

            Assert.AreEqual(resultOrg, resultNew);
        }
    }
}