using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.DAL.Services
{
    public class ElectionRegionService :
        BaseCRUDService<
            ElectionRegion,
            ElectionRegionDTO,
            ElectionRegionSearchRequest,
            ElectionRegionRequest,
            ElectionRegionRequest
            >
        , IElectionRegionService
    {
        public ElectionRegionService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
