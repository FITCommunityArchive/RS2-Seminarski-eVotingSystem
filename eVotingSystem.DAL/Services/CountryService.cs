using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
namespace eVotingSystem.DAL.Services
{
    public class CountryService :
        BaseCRUDService<
            Country,
            CountryDTO,
            CountrySearchRequest,
            CountryRequest,
            CountryRequest
            >
        , ICountryService
    {
        public CountryService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
