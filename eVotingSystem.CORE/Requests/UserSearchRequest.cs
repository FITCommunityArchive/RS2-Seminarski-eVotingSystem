using eVotingSystem.CORE.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class UserSearchRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string CardId { get; set; }
        public string JMBG { get; set; }
        public int? CityId { get; set; }
        public CityDTO City { get; set; }
        public UserTypes? UserTypes { get; set; }
        public int? ElectionUnitId { get; set; }
        public ElectionUnitDTO ElectionUnit { get; set; }
        public int? FileId { get; set; }
        public FileDTO File { get; set; }
        public string Mail { get; set; }
    }
}
