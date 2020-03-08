using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.DAL.Services
{
    public class ElectiveListService :
        BaseCRUDService<
            ElectiveList,
            ElectiveListDTO,
            ElectiveListSearchRequest,
            ElectiveListRequest,
            ElectiveListRequest
            >
        , IElectiveListService
    {
        public ElectiveListService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
