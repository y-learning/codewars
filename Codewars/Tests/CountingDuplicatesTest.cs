using Xunit;

namespace CodeWars.Tests
{
    public class CountingDuplicatesTest
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal( 0, Kata.DuplicateCount( "a" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "aa" ) );
            Assert.Equal( 0, Kata.DuplicateCount( "ba" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "aaa" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "aab" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "abb" ) );
            Assert.Equal( 0, Kata.DuplicateCount( "abc" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "aba" ) );
            Assert.Equal( 0, Kata.DuplicateCount( "abcd" ) );
            Assert.Equal( 2, Kata.DuplicateCount( "aabb" ) );
            Assert.Equal( 2, Kata.DuplicateCount( "abab" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "aabc" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "agha" ) );
            Assert.Equal( 2, Kata.DuplicateCount( "abba" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "zbba" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "zbab" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "zbaa" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "aaaa" ) );
            Assert.Equal( 0, Kata.DuplicateCount( "abcde" ) );
            Assert.Equal( 2, Kata.DuplicateCount( "aabbcde" ) );
            Assert.Equal( 2, Kata.DuplicateCount( "aabBcde" ) );
            Assert.Equal( 1, Kata.DuplicateCount( "Indivisibility" ) );
            Assert.Equal( 2, Kata.DuplicateCount( "Indivisibilities" ) );
        }
    }
}