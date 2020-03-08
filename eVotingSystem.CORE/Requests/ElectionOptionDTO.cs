using eVotingSystem.CORE.Constants;


namespace eVotingSystem.CORE.Requests
{
    public class ElectionOptionDTO 
    {
        public int Id { get; set ; }
        public int? CandidateId { get; set; }
        public CandidateDTO Candidate { get; set; }
        public int? PoliticalOrganizationId { get; set; }
        public PoliticalOrganizationDTO PoliticalOrganization{ get; set; }
        public ElectionOptionType ElectionOptionType { get;set; }
    }
}
