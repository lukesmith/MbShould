using System;
using MbUnit.Framework;

namespace MbShould.Tests
{
    [TestFixture]
    public class ShouldObjectExtensionsTests
    {
        [Test]
        public void should_be_null()
        {
            ((object)null).ShouldBeNull();
        }

        [Test]
        public void should_not_be_null()
        {
            new
                {
                }.ShouldNotBeNull();
        }

        [Test]
        public void should_be_equal_to()
        {
            4.ShouldBeEqualTo(4);
        }

        [Test]
        public void should_not_be_equal_to()
        {
            4.ShouldNotBeEqualTo(5);
        }

        [Test]
        public void should_be_type()
        {
            new Exception().ShouldBeType(typeof(Exception));
        }

        [Test]
        public void should_not_be_type()
        {
            new object().ShouldNotBeType(typeof(Exception));
        }
    }
}
