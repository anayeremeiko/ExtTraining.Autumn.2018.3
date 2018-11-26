using System.Collections.Generic;
using static No3.Solution.Calculator;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            double expected = 8.3636363;

            double actual = values.CalculateMeanAverage();

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            double expected = 8.0;

            double actual = values.CalculateMedianAverage();

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void TestOther_AverageByMean()
        {
            double expected = 8.3636363;

            double actual = values.CalculateMeanAverageOther();

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void TestOther_AverageByMedian()
        {
            double expected = 8.0;

            double actual = values.CalculateMedianAverageOther();

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}