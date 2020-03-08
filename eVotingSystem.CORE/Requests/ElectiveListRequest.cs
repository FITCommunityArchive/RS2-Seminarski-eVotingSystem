using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectiveListRequest
    {
        public int Id { get; set; }
        public string ElectionPositionName { get; set; }
        public int ElectionRegionId { get; set; }

    }
}
