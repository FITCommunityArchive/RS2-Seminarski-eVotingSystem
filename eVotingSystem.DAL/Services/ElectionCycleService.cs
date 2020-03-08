using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
namespace eVotingSystem.DAL.Services
{
    public class ElectionCycleService :
        BaseCRUDService<
            ElectionCycle,
            ElectionCycleDTO,
            ElectionCycleSearchRequest,
            ElectionCycleRequest,
            ElectionCycleRequest
            >
        , IElectionCycleService
    {
        public ElectionCycleService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
