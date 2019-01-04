using System;

namespace Compiler
{
    public class Calculator
    {
        public int Calculate(string experssion)
        {
            return new Interpreter(experssion).Expr();
        }
    }
}
