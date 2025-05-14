using FluentAssertions;

namespace UnitTest.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var result = Target.HellYeah();

            result.Should().BeFalse();
        }
    }
}
