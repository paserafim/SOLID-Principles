using System;

namespace SRP
{
    static class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            // We should not have this tight couple thing - use DI / Interfaces
            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);

            //Console.ReadLine();
            StandardMessages.EndApplication();

        }
    }
}
