
namespace eVotingSystem.CORE.Models
{
    public class ElectionCycle : IEntity
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public bool IsDeleted { get ; set; }
    }
}
