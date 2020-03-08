using eVotingSystem.CORE.Constants;


namespace eVotingSystem.CORE.Models
{
    public class User : IEntity
    {
        public int Id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string CardId { get; set; }
        public string JMBG { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public UserTypes UserTypes { get; set; }
        public int? ElectionUnitId { get; set; }
        public ElectionUnit ElectionUnit { get; set; }
        public int? FileId { get; set; }
        public File File { get; set; }
        public string Mail { get; set; }
        public bool IsDeleted { get ; set ; }
    }
}
