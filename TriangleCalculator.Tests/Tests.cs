using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleCalculator.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestNormalTriangleCalculation()
        {
            TriangleCalculator.CalculateArea(2, 3, 4);
            Assert.AreEqual(2.9, Math.Round(TriangleCalculator.CalculateArea(2, 3, 4), 1));
        }
        [TestMethod]
        [ExpectedException(typeof(WrongTriangleException))]
        public void TestWrongTriangleCalculation()
        {
            TriangleCalculator.CalculateArea(2, 2, 5);
        }
    }
}
