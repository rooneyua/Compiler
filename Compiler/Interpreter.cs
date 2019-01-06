using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class Interpreter : INodeVisitor
    {
        public int Interpret(string expresion)
        {
            var parser = new Parser(expresion);
            AbstractSyntaxTreeNode node = parser.Expr();

            return node.Accept(this);
        }

        public int Visit(NumberNode node)
        {
            return node.IntValue();
        }

        public int Visit(BinaryOperationNode node)
        {
            var left = node.Left.Accept(this);
            var right = node.Right.Accept(this);

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
    }
}
