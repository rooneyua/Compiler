using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    class BinaryOperationNode : AbstractSyntaxTreeNode
    {
        private AbstractSyntaxTreeNode left;
        private AbstractSyntaxTreeNode right;

        public BinaryOperationNode(AbstractSyntaxTreeNode left, AbstractSyntaxTreeNode right, Token token) : base(token)
        {
            this.left = left;
            this.right = right;
        }

        public AbstractSyntaxTreeNode Left => left;
        public AbstractSyntaxTreeNode Right => right;

        public override int Accept(INodeVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
