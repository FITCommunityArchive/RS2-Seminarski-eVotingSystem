using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
namespace eVotingSystem.DAL.Services
{
    public class ElectionOptionService :
        BaseCRUDService<
            ElectionOption,
            ElectionOptionDTO,
            ElectionOptionSearchRequest,
            ElectionOptionRequest,
            ElectionOptionRequest
            >
        , IElectionOptionService
    {
        public ElectionOptionService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
