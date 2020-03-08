

namespace eVotingSystem.CORE.Models
{
    public class ElectiveList : IEntity
    {
        public int Id { get ; set; }
        public string ElectionPositionName { get; set; }
        public int ElectionRegionId { get; set; }
        public ElectionRegion ElectionRegion { get; set; }
        public bool IsDeleted { get ; set; }
    }
}
