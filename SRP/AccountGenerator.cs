using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public static class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            // create a username for the person
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");

        }
    }
}
