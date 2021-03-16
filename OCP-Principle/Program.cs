using System;
using System.Collections.Generic;

namespace OCP_Principle
{
    static class Program
    {
        static void Main(string[] args)
        {
           // One way of knowing if we are not too tight to a class

           List<IApplicantModel> applicants = new List<IApplicantModel>
           {
               new ExecutiveModel { FirstName = "Tim", LastName = "Corey" },
               new PersonModel { FirstName = "cue", LastName = "Storm" },
               new ManagerModel { FirstName = "Paulo", LastName = "Serafim"}
           };

           List<EmployeeModel> employees = new List<EmployeeModel>();
           //Accounts accountProcessor = new Accounts();

           foreach (var person in applicants)
           {
                employees.Add(person.AccountProcessor.Create(person));
           }

           foreach (var emp in employees)
           {
                Console.WriteLine($"{emp.FirstName} {emp.LastName} {emp.EmailAddress} IsManager: {emp.IsManager} ISExecutive: {emp.IsExecutive}");
           }

           Console.ReadLine();

        }
    }
}
