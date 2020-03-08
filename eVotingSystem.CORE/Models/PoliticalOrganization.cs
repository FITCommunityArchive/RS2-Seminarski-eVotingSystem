using eVotingSystem.CORE.Constants;

namespace eVotingSystem.CORE.Models
{
    public class PoliticalOrganization : IEntity
    {
        public int Id { get ; set ; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Ordinal { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public PoliticalOrientation PoliticalOrientation{ get; set; }
        public int? FileId { get; set; }
        public File File { get; set; }
        public int? PictureId { get; set; }
        public File Picture { get; set; }
        public string Details { get; set; }
        public bool IsDeleted { get ; set ; }
    }
}