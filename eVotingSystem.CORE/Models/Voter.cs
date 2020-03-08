using eVotingSystem.CORE.Constants;


namespace eVotingSystem.CORE.Models
{
    public class Voter:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public bool IsVoted { get; set; }
        public int? NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public Gender Gender { get; set; }
        public SchoolingDegreeLevel SchoolingDegreeLevel { get; set; }
        public bool IsDeleted { get; set; }
    }
}
