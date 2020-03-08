using eVotingSystem.CORE.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class VoteRequest
    {
        public int Id { get; set; }
        public Guid Token { get; set; }
        public int ElectionOptionId { get; set; }
        public int? ElectionUnitId { get; set; }
        public int ElectiveListId { get; set; }
        public int? NationalityId { get; set; }
        public int? VoterCityId { get; set; }
        public Gender Gender { get; set; }
        public SchoolingDegreeLevel SchoolingDegreeLevel { get; set; }
        public DateTime TimeOfVoting { get; set; }

    }
}
