using System;
using System.Collections.Generic;
using System.Text;

namespace Compiler
{
    interface INodeVisitor
    {
        int Visit(NumberNode node);
        int Visit(BinaryOperationNode node);
    }
}
