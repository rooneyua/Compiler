using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class Interpreter
    {
        private Lexer lexer;
        private Token currentToken;

        public Interpreter(string expression)
        {
            this.lexer = new Lexer(expression);
        }

        private int IntValue()
        {
            var value = 0;
            int.TryParse(currentToken.Value, out value);

            return value;
        }

        private int Factor()
        {
            currentToken = lexer.NextToken();
            if ("(".Equals(currentToken.Value))
            {
                return Expr();
            }

            return IntValue();
        }

        private int Term()
        {
            var result = Factor();

            currentToken = lexer.NextToken();

            while ("*".Equals(currentToken.Value) || "/".Equals(currentToken.Value))
            {
                if ("*".Equals(currentToken.Value))
                {
                    result = result * Factor();
                }
                else
                if ("/".Equals(currentToken.Value))
                {
                    result = result / Factor();
                }

                currentToken = lexer.NextToken();
            }

            return result;
        }

        public int Expr()
        {
            var result = Term();

            while ("+".Equals(currentToken.Value) || "-".Equals(currentToken.Value))
            { 
                if ("+".Equals(currentToken.Value))
                {
                    result = result + Term();
                }
                else
                if ("-".Equals(currentToken.Value))
                {
                    result = result - Term();
                }
            }

            return result;
        }
    }
}
