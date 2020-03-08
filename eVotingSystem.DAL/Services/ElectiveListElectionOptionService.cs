using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.DAL.Services
{
    public class ElectiveListElectionOptionService :
        BaseCRUDService<
            ElectiveListElectionOption,
            ElectiveListElectionOptionDTO,
            ElectiveListElectionOptionSearchRequest,
            ElectiveListElectionOptionRequest,
            ElectiveListElectionOptionRequest
            >
        , IElectiveListElectionOptionService
    {
        public ElectiveListElectionOptionService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
