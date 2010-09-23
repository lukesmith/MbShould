using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MbUnit.Framework;

namespace MbShould
{
    public static class ShouldEnumerableExtensions
    {
        public static void ShouldContain<T>(this IEnumerable<T> enumeration, T expectedValue)
        {
            Assert.Contains(enumeration, expectedValue);
        }

        public static void ShouldNotContain<T>(this IEnumerable<T> enumeration, T unexpectedValue)
        {
            Assert.DoesNotContain(enumeration, unexpectedValue);
        }

        public static void ShouldHaveACountOf(this IEnumerable values, int expectedCount)
        {
            Assert.Count(expectedCount, values);
        }
    }
}