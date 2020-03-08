﻿namespace eVotingSystem.CORE.Models
{
    public class City : IEntity
    {
        public int Id { get; set ; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country{ get; set; }
        public bool IsDeleted { get ; set ; }
    }
}