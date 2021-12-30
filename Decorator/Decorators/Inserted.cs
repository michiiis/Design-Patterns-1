using Design_Patterns_Assignment.DecoratorAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Inserted : DollDecorator, IDecoration
    {
        public Inserted(IDecoration anyKindOfDoll)
        {
            Start = "<ins>";
            End = "</ins>";
            InutiDockan = anyKindOfDoll;
        }
    }
}
