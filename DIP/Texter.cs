using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"I am texting {person.FirstName} to say {message}.");
        }
    }
}
