

namespace eVotingSystem.CORE.Models
{
    public class ElectiveListElectionOption : IEntity
    {
        public int Id { get; set ; }
        public int ElectiveListId { get; set; }
        public ElectiveList ElectiveList{ get; set; }
        public int ElectionOptionId { get; set; }
        public ElectionOption ElectionOption { get; set; }
        public bool IsDeleted { get ; set ; }
    }
}
