using System.Collections.Generic;
using MbUnit.Framework;

namespace MbShould.Tests
{
    [TestFixture]
    public class ShouldDictionaryExtensionsTests
    {
        [Test]
        public void should_contain_key()
        {
            new Dictionary<string, object>
                {
                    {
                        "1", new object()
                        },
                    {
                        "3", new object()
                        }
                }.ShouldContainKey("1");
        }

        [Test]
        public void should_not_contain_key()
        {
            new Dictionary<string, object>
                {
                    {
                        "1", new object()
                        },
                    {
                        "3", new object()
                        }
                }.ShouldNotContainKey("4");
        }
    }
}
