using NUnit.Framework;

namespace No6.Solution.Tests
{
    using System;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;

    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            var func = new Func<int, int, int>(
                (beforePrevious, previous) => beforePrevious + previous);
            var generator = new RangeGenerator<int>(1, 1, func, 10);
            CollectionAssert.AreEqual(expected, generator.ToArray());
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            var func = new Func<int, int, int>(
                (beforePrevious, previous) => (6 * previous - 8 * beforePrevious));
            var generator = new RangeGenerator<int>(1, 2, func, 10);
            CollectionAssert.AreEqual(expected, generator.ToArray());
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            var func = new Func<double, double, double>(
                (beforePrevious, previous) => (previous + (beforePrevious / previous)));
            var generator = new RangeGenerator<double>(1, 2, func, 10);
            int i = 0;
            foreach (var number in generator)
            {
                Assert.AreEqual(expected[i++], number, 0.0000001);
            }
        }
    }
}
