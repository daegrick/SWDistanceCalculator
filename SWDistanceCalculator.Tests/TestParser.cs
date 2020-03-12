using Microsoft.VisualStudio.TestTools.UnitTesting;
using SWDistanceCalculator.Enums;
using SWDistanceCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWDistanceCalculator.Tests
{
    [TestClass]
    public class TestParser : TestBase
    {
        private readonly IParser parser;
        public TestParser()
        {
            parser = container.GetInstance<IParser>();
        }

        [TestMethod]
        public void TestDay()
        {
            var unit = parser.ParseTimeUnit("day");
            var expected = TimeUnit.Day;
            Assert.AreEqual(expected, unit);
        }

        [TestMethod]
        public void TestDays()
        {
            var unit = parser.ParseTimeUnit("days");
            var expected = TimeUnit.Day;
            Assert.AreEqual(expected, unit);
        }
        [TestMethod]
        public void TestDaysWithSpace()
        {
            var unit = parser.ParseTimeUnit(" days ");
            var expected = TimeUnit.NotValid;
            Assert.AreEqual(expected, unit);
        }

        [TestMethod]
        public void TestMonth()
        {
            var unit = parser.ParseTimeUnit("month");
            var expected = TimeUnit.Month;
            Assert.AreEqual(expected, unit);
        }

        [TestMethod]
        public void TestMonths()
        {
            var unit = parser.ParseTimeUnit("months");
            var expected = TimeUnit.Month;
            Assert.AreEqual(expected, unit);
        }

        [TestMethod]
        public void TestYear()
        {
            var unit = parser.ParseTimeUnit("year");
            var expected = TimeUnit.Year;
            Assert.AreEqual(expected, unit);
        }

        [TestMethod]
        public void TestYears()
        {
            var unit = parser.ParseTimeUnit("years");
            var expected = TimeUnit.Year;
            Assert.AreEqual(expected, unit);
        }

        [TestMethod]
        public void TestWeek()
        {
            var unit = parser.ParseTimeUnit("week");
            var expected = TimeUnit.Week;
            Assert.AreEqual(expected, unit);
        }

        [TestMethod]
        public void TestWeeks()
        {
            var unit = parser.ParseTimeUnit("weeks");
            var expected = TimeUnit.Week;
            Assert.AreEqual(expected, unit);
        }

    }
}