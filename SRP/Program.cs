using System;

namespace SRP
{
    static class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();


            //// Checks to be sure the first and last names are valid
            //if (string.IsNullOrWhiteSpace(user.FirstName))
            //{
            //    Console.WriteLine("You did not give us a valid first name!");
            //    //Console.ReadLine();
            //    StandardMessages.EndApplication();
            //    return;
            //}

            //if (string.IsNullOrWhiteSpace(user.LastName))
            //{
            //    Console.WriteLine("You did not give us a valid last name!");
            //    //Console.ReadLine();
            //    StandardMessages.EndApplication();
            //    return;
            //}

            // create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0,1)}{user.LastName}");

            //Console.ReadLine();
            StandardMessages.EndApplication();

        }
    }
}
