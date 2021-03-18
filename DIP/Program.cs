using System;

namespace DIP
{
    static class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Paulo";
            owner.LastName = "Serafim";
            owner.EmailAddress = "paserafim@gmail.com";
            owner.PhoneNumber = "35195673733";
            //IPerson owner = new Person
            //{
            //    FirstName = "Paulo",
            //    LastName = "Serafim",
            //    EmailAddress = "paserafim@gmail.com",
            //    PhoneNumber = "35195673733"
            //};

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;



            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompletedChore();
        }
    }
}
