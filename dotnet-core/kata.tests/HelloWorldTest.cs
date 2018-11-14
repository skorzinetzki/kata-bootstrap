using FluentAssertions;
using Xunit;

namespace kata.tests
{
    public class HelloWorldTest
    {
        [Fact]
        public void HelloWorldShouldExist()
        {
            var helloWorld = new HelloWorld();

            helloWorld.Should().BeOfType<HelloWorld>();
        }
    }
}
