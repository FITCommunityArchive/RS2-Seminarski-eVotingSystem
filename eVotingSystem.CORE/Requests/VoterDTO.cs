using eVotingSystem.CORE.Constants;


namespace eVotingSystem.CORE.Requests
{
    public class VoterDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        public bool IsVoted { get; set; }
        public int? NationalityId { get; set; }
        public NationalityDTO Nationality { get; set; }
        public Gender Gender { get; set; }
        public SchoolingDegreeLevel SchoolingDegreeLevel { get; set; }
    }
}
