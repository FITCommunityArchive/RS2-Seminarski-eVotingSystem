
namespace eVotingSystem.CORE.Requests
{
    public class ElectionCycleElectiveListDTO 
    {
        public int Id { get ; set ; }
        public int ElectionCycleId { get; set; }
        public ElectionCycleDTO ElectionCycle { get; set; }
        public int ElectiveListId { get; set; }
        public ElectiveListDTO ElectiveList { get; set; }

    }
}
