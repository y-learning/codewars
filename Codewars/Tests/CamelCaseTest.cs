using Xunit;

namespace CodeWars.Tests
{
    public class CamelCaseTest
    {
        [Fact]
        public void Assertions()
        {
            Assert.Equal( "A", Kata.CamelCase( "a" ) );
            Assert.Equal( "Test", Kata.CamelCase( "test" ) );
            Assert.Equal( "TestCase", Kata.CamelCase( "test case" ) );
            Assert.Equal( "CamelCaseMethod", Kata.CamelCase( "camel case method" ) );
            Assert.Equal( "SayHello", Kata.CamelCase( "say hello" ) );
            Assert.Equal( "CamelCaseWord", Kata.CamelCase( " camel case word" ) );
            Assert.Equal( "", Kata.CamelCase( "" ) );
        }
    }
}