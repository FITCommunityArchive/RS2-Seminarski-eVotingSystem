using System;


namespace eVotingSystem.CORE.Requests
{
    public class ElectionUnitDTO 
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public int ElectionRegionId{ get; set; }
        public ElectionRegionDTO ElectionRegion{ get; set; }
        public string Address { get; set; }
        public DateTime VotingBegginingTime { get; set; }
        public DateTime VotingEndTime { get; set; }
    }
}
