using Xunit;

namespace CodeWars.Tests
{
    public class ReversedWordsTest
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal( string.Empty, Kata.ReverseWords( string.Empty ) );
            Assert.Equal( "word", Kata.ReverseWords( "word" ) );
            Assert.Equal( "b a", Kata.ReverseWords( "a b" ) );
            Assert.Equal( "world! hello", Kata.ReverseWords( "hello world!" ) );
            Assert.Equal( "this like speak doesn't yoda", Kata.ReverseWords( "yoda doesn't speak like this" ) );
            Assert.Equal( "foobar", Kata.ReverseWords( "foobar" ) );
            Assert.Equal( "kata editor", Kata.ReverseWords( "editor kata" ) );
            Assert.Equal( "boat your row row row", Kata.ReverseWords( "row row row your boat" ) );
            Assert.Equal( "IWC E   JEUFFNMVLG ", Kata.ReverseWords( " JEUFFNMVLG   E IWC" ) );
        }
    }
}