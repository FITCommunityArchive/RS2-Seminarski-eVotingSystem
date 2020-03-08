using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectiveListElectionOptionRequest
    {
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.Resource.ReqField))]
        public int ElectiveListId { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = nameof(Resources.Resource.ReqField))]
        public int ElectionOptionId { get; set; }
    }
}
