using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
namespace eVotingSystem.DAL.Services
{
    public class VoterService :
        BaseCRUDService<
            Voter,
            VoterDTO,
            VoterSearchRequest,
            VoterRequest,
            VoterRequest
            >
        , IVoterService
    {
        public VoterService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
