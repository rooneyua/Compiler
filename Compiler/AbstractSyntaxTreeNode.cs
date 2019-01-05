using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class AbstractSyntaxTreeNode
    {
        protected Token token;

        public AbstractSyntaxTreeNode(Token token)
        {
            this.token = token;
        }

        public string Value => token.Value;
    }
}
