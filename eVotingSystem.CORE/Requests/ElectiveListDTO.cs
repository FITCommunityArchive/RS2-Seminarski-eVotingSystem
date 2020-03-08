
namespace eVotingSystem.CORE.Requests
{
    public class ElectiveListDTO 
    {
        public int Id { get ; set; }
        public string ElectionPositionName { get; set; }
        public int ElectionRegionId { get; set; }
        public ElectionRegionDTO ElectionRegion { get; set; }
    }
}
