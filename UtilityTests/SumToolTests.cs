using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Utility;

namespace UtilityTests
{
    [TestClass]
    public class SumToolTests
    {
        [TestMethod]
        public void SumEmptyShouldReturnZero()
        {
            Assert.AreEqual(new SumTool().Sum(Array.Empty<int>()), 0);
        }
    }
}
