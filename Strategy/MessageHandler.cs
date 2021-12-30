using Design_Patterns_Assignment.Strategy;
using System;

namespace Design_Patterns_Assignment
{
    internal class MessageHandler
    {
        public IMessageType MessageType { get; set; }

        public void run(string message)
        {
            MessageType.run(message);
        }
    }
}