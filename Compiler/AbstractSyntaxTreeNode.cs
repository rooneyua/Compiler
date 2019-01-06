using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    abstract class AbstractSyntaxTreeNode
    {
        protected Token token;

        public AbstractSyntaxTreeNode(Token token)
        {
            this.token = token;
        }

        public string Value => token.Value;

        abstract public int Accept(INodeVisitor visitor);
    }
}
