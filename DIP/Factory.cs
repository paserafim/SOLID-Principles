using System;
using System.Collections.Generic;
using System.Text;

namespace DIP
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), createMessageSender());
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IMessageSender createMessageSender()
        {
            return new Emailer();
           // return new Texter(); also Works
        }
    }
}
