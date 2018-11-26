using System;
using System.Linq;
using System.Collections.Generic;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            Generator<int> generator = new Generator<int>(1, 1, (a, b) => a + b);
            var sequenece = generator.GenerateSequenece(expected.Length).ToArray();

            CollectionAssert.AreEqual(expected, sequenece);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            Generator<int> generator = new Generator<int>(1, 2, (a, b) => 6 * a - 8 * b);
            var sequenece = generator.GenerateSequenece(expected.Length).ToArray();

            CollectionAssert.AreEqual(expected, sequenece);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            Generator<double> generator = new Generator<double>(1, 2, (a, b) => a + b / a);
            var sequenece = generator.GenerateSequenece(expected.Length).ToArray();

            CollectionAssert.AreEqual(expected,sequenece, Comparer<double>.Create((a,b) => Math.Abs(a-b) < 0.000000001 ? 0 : 1));
        }

        [Test]
        public void Generator_ForSequence4()
        {
            double[] expected = { 1, 2, 2, 4, 8, 32, 256 };

            Generator<double> generator = new Generator<double>(1, 2, (a, b) => a * b);
            var sequenece = generator.GenerateSequenece(expected.Length).ToArray();

            CollectionAssert.AreEqual(expected, sequenece);
        }
    }
}
