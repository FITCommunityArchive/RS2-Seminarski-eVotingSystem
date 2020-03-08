using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
namespace eVotingSystem.DAL.Services
{
    public class ElectionCycleElectiveListService :
        BaseCRUDService<
            ElectionCycleElectiveList,
            ElectionCycleElectiveListDTO,
            ElectionCycleElectiveListSearchRequest,
            ElectionCycleElectiveListRequest,
            ElectionCycleElectiveListRequest
            >
        , IElectionCycleElectiveListService
    {
        public ElectionCycleElectiveListService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
