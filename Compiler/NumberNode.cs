using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class NumberNode : AbstractSyntaxTreeNode
    {
        public NumberNode(Token token) : base(token)
        {
        }

        public int IntValue()
        {
            int.TryParse(token.Value, out int value);

            return value;
        }
    }
}
