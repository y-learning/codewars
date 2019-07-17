using Xunit;

namespace CodeWars.Tests
{
    public class ComplementaryDnaTest
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal( "T", Kata.MakeComplement( "A" ) );
            Assert.Equal( "G", Kata.MakeComplement( "C" ) );
            Assert.Equal( "A", Kata.MakeComplement( "T" ) );
            Assert.Equal( "C", Kata.MakeComplement( "G" ) );
            Assert.Equal( "AA", Kata.MakeComplement( "TT" ) );
            Assert.Equal( "TT", Kata.MakeComplement( "AA" ) );
            Assert.Equal( "TA", Kata.MakeComplement( "AT" ) );
            Assert.Equal( "AT", Kata.MakeComplement( "TA" ) );
            Assert.Equal( "GG", Kata.MakeComplement( "CC" ) );
            Assert.Equal( "CC", Kata.MakeComplement( "GG" ) );
            Assert.Equal( "TAACG", Kata.MakeComplement( "ATTGC" ) );
            Assert.Equal( "CATA", Kata.MakeComplement( "GTAT" ) );
        }
    }
}