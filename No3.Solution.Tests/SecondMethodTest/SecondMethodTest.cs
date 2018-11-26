using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using No3.Solution.SecondMethod;

namespace No3.Solution.Tests.SecondMethodTest
{
    [TestFixture]
    public class SecondMethodTest
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            CalculatorWithAbstractClass calculator = new CalculatorWithAbstractClass();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, new Mean());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            CalculatorWithAbstractClass calculator = new CalculatorWithAbstractClass();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new Median());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
