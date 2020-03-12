using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWDistanceCalculator.Interfaces;
using System;

namespace SWDistanceCalculator.Tests
{
    [TestClass]
    public class TestCalculator : TestBase
    {
        private ICalculator calculator;
        [TestInitialize]
        public void Setup()
        {
            calculator = container.GetInstance<ICalculator>();
        }

        [TestMethod]
        public void TestDays()
        {
            var hours = calculator.CalculateHours(new Models.Duration(1, Enums.TimeUnit.Day));
            var expectedValue = 24;
            Assert.AreEqual(expectedValue, hours);
        }

        [TestMethod]
        public void TestMonths()
        {
            var hours = calculator.CalculateHours(new Models.Duration(1, Enums.TimeUnit.Month));
            var expected = 720;
            Assert.AreEqual(expected, hours);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalid()
        {
            var hours = calculator.CalculateHours(new Models.Duration(-1, Enums.TimeUnit.NotValid));
        }

        [TestMethod]
        public void TestStops()
        {
            var stops = calculator.CalculateStops(1000000, 80, 168);
            var expected = 74;
            Assert.AreEqual(expected, stops);
        }
    }
}
