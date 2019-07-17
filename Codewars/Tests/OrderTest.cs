using Xunit;

namespace CodeWars.Tests
{
    public class OrderTest
    {
        [Fact]
        public void Assertions()
        {
            Assert.Equal( string.Empty, Kata.Order( string.Empty ) );
            Assert.Equal( "Te1st", Kata.Order( "Te1st" ) );
            Assert.Equal( "Thi1s is2 3a T4est", Kata.Order( "is2 Thi1s T4est 3a" ) );
            Assert.Equal( "Fo1r the2 g3ood 4of th5e pe6ople", Kata.Order( "4of Fo1r pe6ople g3ood th5e the2" ) );
        }
    }
}