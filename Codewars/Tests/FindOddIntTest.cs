using Xunit;

namespace CodeWars.Tests
{
    public class FindOddIntTest
    {
        [Fact]
        public void Assertions()
        {
            Assert.Equal( 5, Kata.FindOddInt( 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 ) );
        }
    }
}