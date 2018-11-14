using FluentAssertions;
using NUnit.Framework;

namespace kata.tests
{
    [TestFixture]
    public class HelloWorldTest
    {
        [Test]
        public void HelloWorldClassShouldExist()
        {
            var helloWorld = new HelloWorld();

            helloWorld.Should().BeOfType<HelloWorld>();
        }
    }
}
