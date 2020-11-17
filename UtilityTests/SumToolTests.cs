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
            Assert.AreEqual(0, new SumTool().Sum(Array.Empty<int>()));
        }

        [Test]
        public void SumSingleValueShouldReturnValue()
        {
            Assert.AreEqual(100, new SumTool().Sum(new[] { 100 }));
        }

        [Test]
        public void SumTwoValuesShouldReturnTheAddition()
        {
            Assert.AreEqual(200, new SumTool().Sum(new[] { 100, 100 }));
            Assert.AreEqual(0, new SumTool().Sum(new[] { 100, -100 }));
        }

    }
}
