using Xunit;

namespace CodeWars.Tests
{
    public class CreatePhoneNumberTest
    {
        [Fact]
        public void FixedTest()
        {
            Assert.Equal( "(111) 111-1111", Kata.CreatePhoneNumber( 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 ) );
            Assert.Equal( "(012) 345-6789", Kata.CreatePhoneNumber( 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 ) );
        }
    }
}