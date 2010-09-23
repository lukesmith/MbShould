using MbUnit.Framework;

namespace MbShould.Tests
{
    [TestFixture]
    public class ShouldBooleanExtensionsTests
    {
        [Test]
        public void should_be_true()
        {
            true.ShouldBeTrue();
        }

        [Test]
        public void should_be_false()
        {
            false.ShouldBeFalse();
        }
    }
}
