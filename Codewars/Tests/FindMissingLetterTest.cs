using Xunit;

namespace CodeWars.Tests
{
    public class FindMissingLetterTest
    {
        [Fact]
        public void Assertions()
        {
            Assert.Equal( 'b', Kata.FindMissingLetter( new[] { 'a', 'c' } ) );
            Assert.Equal( 'c', Kata.FindMissingLetter( new[] { 'b', 'd' } ) );
            Assert.Equal( 'e', Kata.FindMissingLetter( new[] { 'a', 'b', 'c', 'd', 'f' } ) );
            Assert.Equal( 'P', Kata.FindMissingLetter( new[] { 'O', 'Q', 'R', 'S' } ) );
        }
    }
}