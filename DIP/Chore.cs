﻿using System;

namespace DIP
{
    public class Chore
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; set; }


        public void PerformedWork(double hours)
        {
            HoursWorked = hours;
            Logger log = new Logger();
            log.Log($"Performed work on { ChoreName} is complete.");

        }

        public void CompletedChore()
        {
            IsComplete = true;

            Logger log = new Logger();
            log.Log($"Completed { ChoreName} is complete.");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}