using eVotingSystem.CORE.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.CORE.Requests
{
    public class VoterRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool IsVoted { get; set; }
        public int? NationalityId { get; set; }
        public Gender Gender { get; set; }
        public SchoolingDegreeLevel SchoolingDegreeLevel { get; set; }
    }
}
