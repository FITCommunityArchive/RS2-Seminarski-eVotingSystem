using eVotingSystem.CORE.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectionOptionRequest
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public int? PoliticalOrganizationId { get; set; }
        [Required(ErrorMessage = nameof(Resources.Resource.ReqField))]
        public ElectionOptionType ElectionOptionType { get; set; }
    }
}
