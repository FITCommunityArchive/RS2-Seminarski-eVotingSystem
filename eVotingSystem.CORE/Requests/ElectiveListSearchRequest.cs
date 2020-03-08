using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectiveListSearchRequest
    {
        public int Id { get; set; }
        public string ElectionPositionName { get; set; }
        public int ElectionRegionId { get; set; }
        public ElectionRegionDTO ElectionRegion { get; set; }
    }
}
