using eVotingSystem.CORE.Constants;
using System;

namespace eVotingSystem.CORE.Models
{
    public class Candidate:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? PoliticalOrganizationId { get; set; }
        public PoliticalOrganization PoliticalOrganization { get; set; }
        public int Ordinal { get; set; }
        public DateTime Birthday { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public Gender Gender{ get; set; }  
        public string Title { get; set; }
        public string Details { get; set; }
        public int? ResumeId { get; set; }
        public File Resume { get; set; }
        public int? PictureId { get; set; }
        public File Picture { get; set; }
        public int NationalityId { get; set; }
        public Nationality Nationality{ get; set; }
        public bool IsDeleted { get; set; }
        
    }
}
