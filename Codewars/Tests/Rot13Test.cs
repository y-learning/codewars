using Xunit;

namespace CodeWars.Tests
{
    public class Rot13Test
    {
        [Fact]
        public void Assertions()
        {
            Assert.Equal( ".", Kata.Rot13( "." ) );
            Assert.Equal( ";", Kata.Rot13( ";" ) );
            Assert.Equal( "!", Kata.Rot13( "!" ) );
            Assert.Equal( "n", Kata.Rot13( "a" ) );
            Assert.Equal( "m", Kata.Rot13( "z" ) );
            Assert.Equal( "k", Kata.Rot13( "x" ) );
            Assert.Equal( "N", Kata.Rot13( "A" ) );
            Assert.Equal( "M", Kata.Rot13( "Z" ) );
            Assert.Equal( "Why", Kata.Rot13( "Jul" ) );
            Assert.Equal( "ROT13 example.", Kata.Rot13( "EBG13 rknzcyr." ) );
        }
    }
}