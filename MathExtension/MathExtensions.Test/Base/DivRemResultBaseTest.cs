﻿using ExtendedAsserts;
using MathExtension.Base;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathExtensions.Test.Base
{
    [TestClass]
    public class DivRemResultBaseTest
    {
        [TestMethod]
        public void IsClassIsAbstract()
        {
            Asserts.IsAbstract<DivRemResultBase<int>>();
        }
    }
}
