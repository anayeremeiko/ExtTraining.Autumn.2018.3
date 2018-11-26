using No6.Solution;
using NUnit.Framework;
using System;
using System.Linq;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};
            int[] calculated = Sequence.GenerateSequence<int>(1, 1, 10, 
                new System.Func<int, int, int>((x, y) => x + y)).ToArray<int>();

            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };
            int[] calculated = Sequence.GenerateSequence<int>(1, 2, 10,
                            new System.Func<int, int, int>((x, y) => 6 * x - 8 * y)).ToArray<int>();

            Assert.AreEqual(expected, calculated);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };
            double[] calculated = Sequence.GenerateSequence<double>(1, 2, 10,
                            new System.Func<double, double, double>((x, y) => x + y / x)).ToArray<double>();

            for (int i = 0; i < expected.Length; i++)
            {
                if (Math.Abs(expected[i] - calculated[i]) > 0.0000000001)
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }
    }
}
