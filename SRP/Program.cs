using System;

namespace SRP
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application");

            // Ask for user information
            Person user = new Person();

            Console.WriteLine("What is your first name:");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name:");
            user.LastName = Console.ReadLine();


            // Checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                Console.ReadLine();
                return;
            }

            // create a username for the person

        }
    }
}
