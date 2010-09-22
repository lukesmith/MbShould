using MbUnit.Framework;

namespace MbShould.Tests
{
    [TestFixture]
    public class ShouldStringExtensionsTests
    {
        public void should_contain_string()
        {
            "Contains the string".ShouldContain("the");
        }
    }
}
