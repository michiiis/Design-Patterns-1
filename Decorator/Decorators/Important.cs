using Design_Patterns_Assignment.DecoratorAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Important : DollDecorator, IDecoration
    {
        public Important(IDecoration anyKindOfDoll)
        {
            Start = "<strong>";
            End = "</strong>";
            InutiDockan = anyKindOfDoll;
        }
    }
}
