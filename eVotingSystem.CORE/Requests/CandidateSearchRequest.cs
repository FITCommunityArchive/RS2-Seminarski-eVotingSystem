using eVotingSystem.CORE.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class CandidateSearchRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? PoliticalOrganizationId { get; set; }
        public PoliticalOrganizationDTO PoliticalOrganization { get; set; }
        public int Ordinal { get; set; }
        public DateTime Birthday { get; set; }
        public int CityId { get; set; }
        public CityDTO City { get; set; }
        public Gender Gender { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int? ResumeId { get; set; }
        public FileDTO Resume { get; set; }
        public int? PictureId { get; set; }
        public FileDTO Picture { get; set; }
        public int? NationalityId { get; set; }
        public NationalityDTO Nationality { get; set; }
    }
}
