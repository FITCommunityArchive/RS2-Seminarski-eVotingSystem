using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectionRegionSearchRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SuperiorElectionRegionDTOId { get; set; }
        public ElectionRegionDTO SuperiorElectionRegionDTO { get; set; }
    }
}
