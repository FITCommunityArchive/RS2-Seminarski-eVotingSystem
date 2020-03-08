using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.DAL.Services
{
    public class CandidateService :
        BaseCRUDService<
            Candidate,
            CandidateDTO,
            CandidateSearchRequest,
            CandidateRequest,
            CandidateRequest
            >
        , ICandidateService
    {
        public CandidateService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
