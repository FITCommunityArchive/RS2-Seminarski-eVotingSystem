namespace eVotingSystem.CORE.Models
{
    public class Nationality : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get ; set ; }
    }
}