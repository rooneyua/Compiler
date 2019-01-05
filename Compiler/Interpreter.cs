using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class Interpreter
    {
        public int Interpret(string expresion)
        {
            var parser = new Parser(expresion);
            AbstractSyntaxTreeNode node = parser.Expr();
            
            return Evaluate(node);
        }

        private int Visit(NumberNode node)
        {
            return node.IntValue();
        }

        private int Visit(BinaryOperationNode node)
        {
            var left = Evaluate(node.Left);
            var right = Evaluate(node.Right);

            if ("+".Equals(node.Value))
            {
                return left + right;
            }
            else
            if ("-".Equals(node.Value))
            {
                return left - right;
            }
            else
            if ("*".Equals(node.Value))
            {
                return left * right;
            }
            else
            if ("/".Equals(node.Value))
            {
                return left / right;
            }

            return 0;
        }

        private int Evaluate(AbstractSyntaxTreeNode node)
        {
            if (node.GetType() == typeof(NumberNode))
            {
                return Visit((NumberNode)node);
            }
            else
            if (node.GetType() == typeof(BinaryOperationNode))
            {
                return Visit((BinaryOperationNode)node);
            }

            return 0;
        }
    }
}
