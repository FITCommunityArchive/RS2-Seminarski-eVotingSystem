namespace eVotingSystem.CORE.Models
{
    public interface IEntity
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
