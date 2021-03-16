using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Principle
{
    public class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}.{person.LastName}@mymail-corp.com";

            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}
