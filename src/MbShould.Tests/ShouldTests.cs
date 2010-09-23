using System;
using MbUnit.Framework;

namespace MbShould.Tests
{
    [TestFixture]
    public class ShouldTests
    {
        [Test]
        public void should_throw_exception()
        {
            Should.Throw(() => { throw new Exception(); });
        }

        [Test]
        public void should_throw_specific_exception()
        {
            Should.Throw<InvalidOperationException>(() => { throw new InvalidOperationException(); });
        }

        [Test]
        public void should_throw_exception_with_message()
        {
            Should.Throw(() => { throw new Exception("An exception message"); }, "exception message");
        }

        [Test]
        public void should_throw_specific_exception_with_message()
        {
            Should.Throw<InvalidOperationException>(() => { throw new InvalidOperationException("An exception message"); }, "exception message");
        }

        [Test]
        public void should_not_throw_exception()
        {
            Should.Throw(() => Should.NotThrow(() => { throw new Exception(); }));
        }

        [Test]
        public void should_not_throw_specific_exception()
        {
            Should.Throw<Exception>(() => Should.NotThrow<InvalidOperationException>(() => { throw new Exception(); }));
        }
    }
}