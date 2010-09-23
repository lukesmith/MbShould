using MbUnit.Framework;

namespace MbShould.Tests
{
    [TestFixture]
    public class ShouldStringExtensionsTests
    {
        [Test]
        public void should_contain_string()
        {
            "Contains the string".ShouldContain("the");
        }

        [Test]
        public void should_contain_string_when_expected_is_uppercase()
        {
            "Contains the string".ShouldContain("THE");
        }

        [Test]
        public void should_not_contain_string()
        {
            "Contains the string".ShouldNotContain("cat");
        }

        [Test]
        public void should_not_contain_string_when_unexpected_is_uppercase()
        {
            "Contains the string".ShouldNotContain("CAT");
        }
    }
}
