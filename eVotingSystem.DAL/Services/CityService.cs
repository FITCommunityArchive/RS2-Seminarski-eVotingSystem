using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.DAL.Services
{
    public class CityService :
        BaseCRUDService<
            City,
            CityDTO,
            CitySearchRequest,
            CityRequest,
            CityRequest
            >
        , ICityService
    {
        public CityService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    } 
}
