﻿

namespace eVotingSystem.CORE.Requests
{
    public class ElectiveListElectionOptionDTO 
    {
        public int Id { get; set ; }
        public int ElectiveListId { get; set; }
        public ElectiveListDTO ElectiveList{ get; set; }
        public int ElectionOptionId { get; set; }
        public ElectionOptionDTO ElectionOption { get; set; }
    }
}
