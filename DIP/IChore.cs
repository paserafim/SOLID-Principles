namespace DIP
{
    public interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; set; }
        IPerson Owner { get; set; }

        void CompletedChore();
        void PerformedWork(double hours);
    }
}