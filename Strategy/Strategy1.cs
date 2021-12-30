using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Strategy
{
    internal class Strategy1
    {
        internal static void Run()
        {
            Console.WriteLine("Strategy");
            var message = "This is the message";
            MessageHandler messageHandler = new();
            Sms sms = new();
            FacebookMessage facebookMessage = new();
            Emails email = new();

            while (true)
            {
            Console.WriteLine("Choose Method to send message with");
            var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'f':
                        Console.WriteLine("facebook massenger");
                        messageHandler.MessageType = facebookMessage;
                        break;
                    case 's':
                        Console.WriteLine("SMS");
                        messageHandler.MessageType = sms;
                        break;
                    case 'e':
                        Console.WriteLine("Email");
                        messageHandler.MessageType = email;
                        break;
                    case 'q':
                        messageHandler.run(message);
                        break;
                }
            }
        }
    }
}
