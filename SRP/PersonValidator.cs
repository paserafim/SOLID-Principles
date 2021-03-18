using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    public static class PersonValidator
    {
        public static bool Validate(Person person)
        {
            // Checks to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                StandardMessages.EndApplication();
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                StandardMessages.EndApplication();
                return false;
            }

            return true;
        }
    }
}
