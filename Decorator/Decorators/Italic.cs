using Design_Patterns_Assignment.DecoratorAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    class Italic : DollDecorator, IDecoration
    {

        public Italic(IDecoration anyKindOfDoll)
        {
            Start = "<i>";
            End = "</i>";
            InutiDockan = anyKindOfDoll;
        }
    }
}
