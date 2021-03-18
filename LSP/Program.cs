using System;

namespace LSP
{
    static class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Emma Stone";
            accountingVP.CalculatePerHourRate(4);

            // We can switch the type without break
            IManaged emp = new Manager();

            emp.FirstName = "Paulo";
            emp.LastName = "Serafim";
            emp.AssignManager(accountingVP); // The problem is here.
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();


        }
    }
}
