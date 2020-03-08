
namespace eVotingSystem.CORE.Requests
{
    public class CityDTO 
    {
        public int Id { get; set ; }

        public string Name { get; set; }
        public int CountryId { get; set; }
        public CountryDTO Country{ get; set; }
    }
}