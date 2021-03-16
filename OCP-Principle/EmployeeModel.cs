namespace OCP_Principle
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        // added - OCP in the developing process don't apply, only after
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; }


    }
}