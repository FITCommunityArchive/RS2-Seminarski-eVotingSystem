namespace eVotingSystem.CORE.Models
{
    public class ElectionRegion : IEntity
    {
        public int Id { get; set ; }
        public  string Name { get; set; }
        public int? SuperiorRegionId { get; set; }
        public ElectionRegion SuperiorElectionRegion { get; set; }
        public bool IsDeleted { get; set; }
    }
}