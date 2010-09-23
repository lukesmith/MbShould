using MbUnit.Framework;

namespace MbShould.Tests
{
    [TestFixture]
    public class ShouldEnumerableExtensionsTests
    {
        [Test]
        public void should_contain()
        {
            new[]
                {
                    3, 4, 5
                }.ShouldContain(3);
        }

        [Test]
        public void should_not_contain()
        {
            new[]
                {
                    3, 4, 5
                }.ShouldNotContain(6);
        }

        [Test]
        public void should_have_a_count_of()
        {
            new[]
                {
                    3, 4, 5
                }.ShouldHaveACountOf(3);
        }
    }
}