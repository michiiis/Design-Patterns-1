using Design_Patterns_Assignment.DecoratorAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Emphasized : DollDecorator, IDecoration
    {
        public Emphasized(IDecoration anyKindOfDoll)
        {
            Start = "<em>";
            End = "</em>";
            InutiDockan = anyKindOfDoll;
        }
    }
}
