using eVotingSystem.CORE.Constants;
using System;


namespace eVotingSystem.CORE.Requests
{
    public class VoteDTO
    {
        public int Id { get ; set ; }
        public Guid Token { get; set; }
        public int ElectionOptionId { get; set; }
        public ElectionOptionDTO ElectionOption { get; set; }
        public int? ElectionUnitId { get; set; }
        public int ElectiveListId { get; set; }
        public ElectiveListDTO ElectiveList { get; set; }
        public ElectionUnitDTO ElectionUnit { get; set; }
        public int? NationalityId { get; set; }
        public NationalityDTO Nationality { get; set; }
        public int? VoterCityId { get; set; }
        public CityDTO VoterCity { get; set; }
        public Gender Gender { get; set; }
        public SchoolingDegreeLevel SchoolingDegreeLevel { get; set; }
        public DateTime TimeOfVoting { get; set; }

    }
}
