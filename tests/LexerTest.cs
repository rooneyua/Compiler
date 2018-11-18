using Compiler;
using Xunit;

namespace tests
{
    public class LexerTest
    {
        [Fact]
        public void NextToken_EmptyExpression_EOFToken()
        {
            Lexer tested = new Lexer("");
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_NullExpression_EOFToken()
        {
            Lexer tested = new Lexer(null);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_SingleValueExpression_OneToken()
        {
            Lexer tested = new Lexer("1");
            Assert.Equal("1", tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_ThreeValueExpression_FourTokens()
        {
            Lexer tested = new Lexer("1+2");
            Assert.Equal("1", tested.NextToken().Value);
            Assert.Equal("+", tested.NextToken().Value);
            Assert.Equal("2", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

    }
}
