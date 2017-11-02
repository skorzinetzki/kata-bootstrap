using FluentAssertions;
using NUnit.Framework;

namespace kata.tests
{
    [TestFixture]
    public class HelloWorldTest
    {
        [Test]
        public void HelloWorldShouldBeTrue()
        {
            var helloWorld = false;

            helloWorld.Should().BeTrue();
        }
    }
}
