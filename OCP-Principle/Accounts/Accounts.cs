using System;

namespace OCP_Principle
{
    public class Accounts : IAccounts
    {
        // We should not change this.
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@mymail.com";

            return output;
        }
    }
}