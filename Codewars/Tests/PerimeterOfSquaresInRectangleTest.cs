using System.Numerics;
using Xunit;

namespace CodeWars.Tests
{
    public class PerimeterOfSquaresInRectangleTest
    {
        [Fact]
        public void Assertions()
        {
            Assert.Equal( new BigInteger( 8 ), Perimeter( new BigInteger( 1 ) ) );
            Assert.Equal( new BigInteger( 16 ), Perimeter( new BigInteger( 2 ) ) );
            Assert.Equal( new BigInteger( 28 ), Perimeter( new BigInteger( 3 ) ) );
            Assert.Equal( new BigInteger( 48 ), Perimeter( new BigInteger( 4 ) ) );
            Assert.Equal( new BigInteger( 80 ), Perimeter( new BigInteger( 5 ) ) );
            Assert.Equal( new BigInteger( 216 ), Perimeter( new BigInteger( 7 ) ) );
        }

        private static BigInteger Perimeter( BigInteger n )
        {
            var fibonacciSequence = new BigInteger[(int) n + 1];
            fibonacciSequence[0] = 1;
            fibonacciSequence[1] = 1;
            var sum = BigInteger.Zero;

            for ( var i = 2; i <= n; i++ )
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
                sum += fibonacciSequence[i];
            }

            return 4 * ( sum + fibonacciSequence[0] + fibonacciSequence[1] );
        }
    }
}