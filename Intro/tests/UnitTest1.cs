using System;
using Xunit;
using logic;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var expectedMessage  = "Hello Immo!";
            var actualMessage = HelloWorld.GetMessage("Immo");
            Assert.Equal(expectedMessage, actualMessage);
        }
    }
}
