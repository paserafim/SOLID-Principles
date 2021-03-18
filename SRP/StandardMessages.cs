using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public static class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidationError(string field)
        {
            Console.WriteLine($"You did not give us a valid { field } name!");
        }
    }
}
