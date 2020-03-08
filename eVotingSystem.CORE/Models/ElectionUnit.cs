

using System;

namespace eVotingSystem.CORE.Models
{
    public class ElectionUnit : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public int ElectionRegionId{ get; set; }
        public ElectionRegion ElectionRegion{ get; set; }
        public string Address { get; set; }
        public string Details { get; set; }
        public DateTime VotingBegginingTime { get; set; }
        public DateTime VotingEndTime { get; set; }
        public bool IsDeleted { get ; set ; }
    }
}
