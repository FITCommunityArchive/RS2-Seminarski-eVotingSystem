namespace eVotingSystem.DAL.Helpers
{
    public class Pagination
    {
        public int Page { get; set; } 
        public int Amount { get; set; } 
        public int SkipAmount { get => Page * Amount; private set { } }
        public int NumberOfRecords { get; set; }
    }
}
