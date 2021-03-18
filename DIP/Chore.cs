using System;

namespace DIP
{
    public class Chore : IChore
    {
        private ILogger _logger;
        private IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked = hours;
            //Logger log = new Logger();
            //log.Log($"Performed work on { ChoreName} is complete.");
            _logger.Log($"Performed work on { ChoreName} is complete.");

        }

        public void CompletedChore()
        {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName} is complete.");
            //Logger log = new Logger();
            //log.Log($"Completed { ChoreName} is complete.");

            _messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
            //Emailer emailer = new Emailer();
            //emailer.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}