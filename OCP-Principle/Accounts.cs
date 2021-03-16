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

            //if (person.TypeOfEmployee == EmployeeType.Manager)
            //{
            //    // violating OCP
            //    output.IsManager = true;
            //}

            //switch (person.TypeOfEmployee)
            //{
            //    case EmployeeType.Staff:
            //        break;
            //    case EmployeeType.Manager:
            //        output.IsManager = true;
            //        break;
            //    case EmployeeType.Executive:
            //        output.IsManager = true;
            //        output.IsExecutive = true;
            //        break;
            //}

            return output;
        }
    }
}