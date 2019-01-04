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
        public void NextToken_TwoDigitsValueExpression_OneToken()
        {
            Lexer tested = new Lexer("10");
            Assert.Equal("10", tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_TwoDigitsWithPlusValueExpression_TwoTokens()
        {
            Lexer tested = new Lexer("10+");
            Assert.Equal("10", tested.NextToken().Value);
            Assert.Equal("+", tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_TwoNumbersWithTwoDigitsWithPlusValueExpression_FourTokens()
        {
            Lexer tested = new Lexer("10+11");
            Assert.Equal("10", tested.NextToken().Value);
            Assert.Equal("+", tested.NextToken().Value);
            Assert.Equal("11", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
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

        [Fact]
        public void NextToken_ThreeValueExpressionWithSpaces_FourTokens()
        {
            Lexer tested = new Lexer("1 + 2");
            Assert.Equal("1", tested.NextToken().Value);
            Assert.Equal("+", tested.NextToken().Value);
            Assert.Equal("2", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_ThreeValueExpressionWithMinus_FourTokens()
        {
            Lexer tested = new Lexer("1 - 2");
            Assert.Equal("1", tested.NextToken().Value);
            Assert.Equal("-", tested.NextToken().Value);
            Assert.Equal("2", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_MultiplyExpression_TwoTokens()
        {
            Lexer tested = new Lexer("*");
            Assert.Equal("*", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_DivideExpression_TwoTokens()
        {
            Lexer tested = new Lexer("/");
            Assert.Equal("/", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_RightExpression_TwoTokens()
        {
            Lexer tested = new Lexer("(");
            Assert.Equal("(", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }

        [Fact]
        public void NextToken_LeftExpression_TwoTokens()
        {
            Lexer tested = new Lexer(")");
            Assert.Equal(")", tested.NextToken().Value);
            Assert.Equal(Token.EOF, tested.NextToken().Value);
        }
    }
}
