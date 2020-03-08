

namespace eVotingSystem.CORE.Models
{
    public class ElectionCycleElectiveList : IEntity
    {
        public int Id { get ; set ; }
        public int ElectionCycleId { get; set; }
        public ElectionCycle ElectionCycle { get; set; }
        public int ElectiveListId { get; set; }
        public ElectiveList ElectiveList { get; set; }
        public bool IsDeleted { get ; set ; }
    }
}
