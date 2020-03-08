

namespace eVotingSystem.CORE.Models
{
    public class Country : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public bool IsDeleted { get ; set ; }
    }
}
