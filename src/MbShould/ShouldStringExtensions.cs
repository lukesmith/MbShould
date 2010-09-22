using MbUnit.Framework;

namespace MbShould
{
    public static class ShouldStringExtensions
    {
        public static void ShouldContain(this string actualValue, string expectedSubstring)
        {
            Assert.Contains(actualValue, expectedSubstring);
        }
    }
}
