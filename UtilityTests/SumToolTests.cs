using NUnit.Framework;
using System;
using Utility;

namespace UtilityTests
{
    [TestFixture]
    public class SumToolTests
    {
        [Test]
        public void SumEmptyShouldReturnZero()
        {
            Assert.AreEqual(new SumTool().Sum(Array.Empty<int>()), 0);
        }

        [Test]
        public void SumSingleValueShouldReturnValue()
        {
            Assert.AreEqual(new SumTool().Sum(new[] { 100 }), 100);
        }

        [Test]
        public void SumTwoValuesShouldReturnTheAddition()
        {
            Assert.AreEqual(new SumTool().Sum(new[] { 100, 100 }), 200);
            Assert.AreEqual(new SumTool().Sum(new[] { 100, -100 }), 1);
        }

    }
}
