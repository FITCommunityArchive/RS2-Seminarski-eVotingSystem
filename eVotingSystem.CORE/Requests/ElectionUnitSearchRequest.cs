using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectionUnitSearchRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ElectionRegionId { get; set; }
        public ElectionRegionDTO ElectionRegion { get; set; }
        public string Address { get; set; }
        public DateTime VotingBegginingTime { get; set; }
        public DateTime VotingEndTime { get; set; }
    }
}
