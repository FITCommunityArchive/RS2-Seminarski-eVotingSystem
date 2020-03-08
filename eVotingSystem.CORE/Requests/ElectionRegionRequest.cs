using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectionRegionRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? SuperiorElectionRegionDTOId { get; set; }
    }
}
