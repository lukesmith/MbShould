using System.Collections.Generic;
using MbUnit.Framework;

namespace MbShould
{
    public static class ShouldDictionaryExtensions
    {
        public static void ShouldContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey expectedKey)
        {
            Assert.ContainsKey(dictionary, expectedKey);
        }

        public static void ShouldNotContainKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey unexpectedKey)
        {
            Assert.DoesNotContainKey(dictionary, unexpectedKey);
        }
    }
}
