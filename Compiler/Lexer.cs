using System;

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

            string lexema = "";

            while (expression.Length > currentPosition)
            {
                var sumbol = expression.Substring(currentPosition, 1);

                if (string.IsNullOrEmpty(sumbol.Trim()))
                {
                    currentPosition++;
                    continue;
                }

                if (("+".Equals(sumbol) || "-".Equals(sumbol)) && string.IsNullOrEmpty(lexema))
                {
                    currentPosition++;
                    return new Token(sumbol);
                }

                if (Int32.TryParse(sumbol, out int x))
                {
                    lexema = lexema + sumbol;
                }
                else
                {
                    return new Token(lexema);
                }

                currentPosition++;
            }

            return new Token(lexema);
        }
    }
}