using System;

namespace Compiler
{
    public class Calculator
    {
        public string Calculate(string experssion)
        {
            if (string.IsNullOrEmpty(experssion))
            {
                return "";
            }

            var lexer = new Lexer(experssion);
            var token = lexer.NextToken();

            if (!int.TryParse(token.Value, out int left) || Token.EOF.Equals(token.Value))
            {
                return "";
            }

            while (true)
            {
                var operation = lexer.NextToken();
                if (Token.EOF.Equals(operation.Value))
                {
                    break;
                }

                var rightToken = lexer.NextToken();
                if (Token.EOF.Equals(rightToken.Value))
                {
                    break;
                }

                if (int.TryParse(rightToken.Value, out int right))
                {
                    if ("+".Equals(operation.Value))
                    {
                        left = left + right;
                    }
                    else
                    if ("-".Equals(operation.Value))
                    {
                        left = left - right;
                    }
                    else
                    if ("*".Equals(operation.Value))
                    {
                        left = left * right;
                    }
                    else
                    if ("/".Equals(operation.Value))
                    {
                        left = left / right;
                    }
                    else
                    {
                        return "";
                    }
                }
                else
                {
                    return "";
                }
            }

            return left.ToString();
        }
    }
}
