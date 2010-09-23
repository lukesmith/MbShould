using MbUnit.Framework;

namespace MbShould
{
    public static class ShouldBooleanExtensions
    {
        public static void ShouldBeTrue(this bool actualValue)
        {
            Assert.IsTrue(actualValue);
        }

        public static void ShouldBeFalse(this bool actualValue)
        {
            Assert.IsFalse(actualValue);
        }
    }
}
