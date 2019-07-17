using Xunit;

namespace CodeWars.Tests
{
    public class IsogramsTest
    {
        private static void AssertIsIsogram( string word )
        {
            Assert.True( Kata.IsIsogram( word ) );
        }

        private static void AssertIsNoIsogram( string word )
        {
            Assert.False( Kata.IsIsogram( word ) );
        }

        [Fact]
        public void AssertIsograms()
        {
            AssertIsIsogram( string.Empty );
            AssertIsIsogram( "ab" );
            AssertIsIsogram( "Dermatoglyphics" );
            AssertIsIsogram( "isogram" );
            AssertIsIsogram( "thumbscrewjapingly" );
        }

        [Fact]
        public void AssertNotIsograms()
        {
            AssertIsNoIsogram( "Aa" );
            AssertIsNoIsogram( "moose" );
            AssertIsNoIsogram( "isIsogram" );
            AssertIsNoIsogram( "aba" );
            AssertIsNoIsogram( "moOse" );
        }
    }
}