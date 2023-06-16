using System.Collections.Generic;
using NUnit.Framework;

namespace Algorithms.Tests.Maths
{
    [TestFixture]
    public class FibonacciSequence
    {
        [TestCase(20, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181 })]
        [TestCase(30, new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610, 987, 1597, 2584, 4181, 6765, 10946, 17711, 28657, 46368, 75025, 121393, 196418, 317811, 514229 })]
        public void CalculateFibonacciSeriesTest(int value, int[] expected) {
            var result = Algorithms.Maths.FibonacciSequence.FibonacciSeries(value);
            Assert.AreEqual(expected, result);
        }
    }
}