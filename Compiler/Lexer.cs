
namespace Compiler
{
    public class Lexer
    {
        private readonly string expression;
        private int currentPosition = 0;

        public Lexer(string expression)
        {
            this.expression = expression;
        }

        public Token NextToken()
        {
            if (string.IsNullOrEmpty(expression) || expression.Length <= currentPosition)
            {
                return new Token(Token.EOF);
            }

            return new Token(expression.Substring(currentPosition++, 1));
        }
    }
}