using eVotingSystem.CORE.Constants;
using System;


namespace eVotingSystem.CORE.Models
{
    public class Vote : IEntity
    {
        public int Id { get ; set ; }
        public Guid Token { get; set; }
        public int ElectionOptionId { get; set; }
        public ElectionOption ElectionOption { get; set; }
        public int ElectiveListId { get; set; }
        public ElectiveList ElectiveList { get; set; }
        public int? ElectionUnitId { get; set; }
        public ElectionUnit ElectionUnit { get; set; }
        public int? NationalityId { get; set; }
        public Nationality Nationality { get; set; }
        public int? VoterCityId { get; set; }
        public City VoterCity { get; set; }
        public Gender Gender { get; set; }
        public SchoolingDegreeLevel SchoolingDegreeLevel { get; set; }
        public DateTime TimeOfVoting { get; set; }
        public bool IsDeleted { get; set; }

    }
}
