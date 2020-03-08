namespace eVotingSystem.CORE.Requests
{
    public class ElectionRegionDTO 
    {
        public int Id { get; set ; }
        public  string Name { get; set; }
        public int? SuperiorElectionRegionDTOId { get; set; }
        public ElectionRegionDTO SuperiorElectionRegionDTO { get; set; }
    }
}