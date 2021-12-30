using Design_Patterns_Assignment.DecoratorAssignment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    abstract class DollDecorator
    {
        public string Start { get; set; }
        public string End { get; set; }
        public IDecoration InutiDockan { get; set; }
        public DollDecorator()
        {
        }

        public string Content()
        {
            return Start + InutiDockan.Content() + End;

        }
    }
}
