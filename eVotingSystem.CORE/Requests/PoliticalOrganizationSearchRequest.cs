using eVotingSystem.CORE.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class PoliticalOrganizationSearchRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Ordinal { get; set; }
        public int CityId { get; set; }
        public CityDTO City { get; set; }
        public PoliticalOrientation PoliticalOrientation { get; set; }
        public int? FileId { get; set; }
        public FileDTO File { get; set; }
        public int? PictureId { get; set; }
        public FileDTO Picture { get; set; }
        public string Details { get; set; }
    }
}
