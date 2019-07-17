using Xunit;

namespace CodeWars.Tests
{
    public class SquareTest
    {
        [Fact]
        public void ShouldWorkForSomeExamples()
        {
            Assert.True( Kata.IsSquare( 0 ) );
            Assert.True( Kata.IsSquare( 4 ) );
            Assert.True( Kata.IsSquare( 25 ) );
            Assert.True( Kata.IsSquare( 1 ) );
            Assert.False( Kata.IsSquare( -1 ) );
            Assert.False( Kata.IsSquare( 3 ) );
            Assert.False( Kata.IsSquare( 3 ) );
            Assert.False( Kata.IsSquare( 26 ) );
        }
    }
}