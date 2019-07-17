using Xunit;

namespace CodeWars.Tests
{
    public class SimplePigLatinTest
    {
        [Fact]
        public void Assertions()
        {
            Assert.Equal( "aay", Kata.PigIt( "a" ) );
            Assert.Equal( "igPay", Kata.PigIt( "Pig" ) );
            Assert.Equal( "igPay atinlay", Kata.PigIt( "Pig latin" ) );
            Assert.Equal( "igPay atinlay siay oolcay", Kata.PigIt( "Pig latin is cool" ) );
            Assert.Equal( "hisTay siay ymay tringsay", Kata.PigIt( "This is my string" ) );
            Assert.Equal( "elloHay orldway !", Kata.PigIt( "Hello world !" ) );
        }
    }
}