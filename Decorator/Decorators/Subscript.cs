using Design_Patterns_Assignment.DecoratorAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Subscript : DollDecorator, IDecoration
    {
        public Subscript(IDecoration anyKindOfDoll)
        {
            Start = "<sub>";
            End = "</sub>";
            InutiDockan = anyKindOfDoll;
        }
    }
}
