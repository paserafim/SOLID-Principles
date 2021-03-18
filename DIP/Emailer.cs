using System;

namespace DIP
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending email to { person.EmailAddress }");
        }
    }
}