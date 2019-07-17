using Xunit;

namespace CodeWars.Tests
{
    public class BinaryAdditionTest
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal( "0", Kata.AddBinary( 0, 0 ) );
            Assert.Equal( "101", Kata.AddBinary( 2, 3 ) );
        }
    }
}