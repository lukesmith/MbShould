using System;
using MbUnit.Framework;

namespace MbShould
{
    public static class ShouldObjectExtensions
    {
        public static void ShouldBeNull<T>(this T actualValue)
        {
            Assert.IsNull(actualValue);
        }

        public static void ShouldNotBeNull<T>(this T actualValue)
        {
            Assert.IsNotNull(actualValue);
        }

        public static void ShouldBeEqualTo<T>(this T actualValue, T expectedValue)
        {
            Assert.AreEqual(expectedValue, actualValue);
        }

        public static void ShouldNotBeEqualTo<T>(this T actualValue, T unexpectedValue)
        {
            Assert.AreNotEqual(unexpectedValue, actualValue);
        }

        public static void ShouldBeType<T>(this T actualValue, Type expectedType)
        {
            Assert.AreEqual(expectedType, actualValue.GetType());
        }

        public static void ShouldNotBeType<T>(this T actualValue, Type unexpectedType)
        {
            Assert.AreNotEqual(unexpectedType, actualValue.GetType());
        }
    }
}
