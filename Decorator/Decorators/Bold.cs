using Design_Patterns_Assignment.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorAssignment
{
    class Bold : DollDecorator, IDecoration
    {
        public Bold(IDecoration anyKindOfDoll)
        {
            Start = "<b>";
            End = "</b>";
            InutiDockan = anyKindOfDoll;
        }

    }
}


