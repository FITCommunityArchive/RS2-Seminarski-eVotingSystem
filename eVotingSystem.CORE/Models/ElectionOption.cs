using eVotingSystem.CORE.Constants;


namespace eVotingSystem.CORE.Models
{
    public class ElectionOption : IEntity
    {
        public int Id { get; set ; }
        public int? CandidateId { get; set; }
        public Candidate Candidate { get; set; }
        public int? PoliticalOrganizationId { get; set; }
        public PoliticalOrganization PoliticalOrganization{ get; set; }
        public ElectionOptionType ElectionOptionType { get;set; }
        public bool IsDeleted { get; set ; }
    }
}
