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

            var right = lexer.NextToken();
            var operation = lexer.NextToken();
            var left = lexer.NextToken();

            if (Int32.TryParse(right.Value, out int x) && Int32.TryParse(left.Value, out int y))
            {
                if ("+".Equals(operation.Value))
                {
                    var result = x + y;
                    return result.ToString();
                }

                if ("-".Equals(operation.Value))
                {
                    var result = x - y;
                    return result.ToString();
                }
            }

            return "";
        }
    }
}
