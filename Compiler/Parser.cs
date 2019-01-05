using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class Parser
    {
        private Lexer lexer;
        private Token currentToken;

        public Parser(string expression)
        {
            this.lexer = new Lexer(expression);
        }

        private int IntValue()
        {
            var value = 0;
            int.TryParse(currentToken.Value, out value);

            return value;
        }

        private AbstractSyntaxTreeNode Factor()
        {
            currentToken = lexer.NextToken();
            if ("(".Equals(currentToken.Value))
            {
                return Expr();
            }

            return new NumberNode(currentToken);
        }

        private AbstractSyntaxTreeNode Term()
        {
            var result = Factor();

            currentToken = lexer.NextToken();

            while ("*".Equals(currentToken.Value) || "/".Equals(currentToken.Value))
            {
                var token = currentToken;
                result = new BinaryOperationNode(result, Factor(), token);

                currentToken = lexer.NextToken();
            }

            return result;
        }

        public AbstractSyntaxTreeNode Expr()
        {
            var result = Term();

            while ("+".Equals(currentToken.Value) || "-".Equals(currentToken.Value))
            {
                var token = currentToken;
                result = new BinaryOperationNode(result, Term(), token);
            }

            return result;
        }
    }
}
