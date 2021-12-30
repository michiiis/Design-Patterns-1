using Design_Patterns_Assignment.DecoratorAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Deleted : DollDecorator, IDecoration
    {
        public Deleted(IDecoration anyKindOfDoll)
        {
            Start = "<del>";
            End = "</del>";
            InutiDockan = anyKindOfDoll;
        }
    }
}
