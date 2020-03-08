using eVotingSystem.CORE.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class ElectionOptionSearchRequest
    {
        public int Id { get; set; }
        public int? CandidateId { get; set; }
        public CandidateDTO Candidate { get; set; }
        public int? PoliticalOrganizationId { get; set; }
        public PoliticalOrganizationDTO PoliticalOrganization { get; set; }
        public ElectionOptionType ElectionOptionType { get; set; }
    }
}
