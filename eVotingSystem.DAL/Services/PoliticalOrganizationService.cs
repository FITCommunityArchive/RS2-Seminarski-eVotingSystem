using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.DAL.Services
{
    public class PoliticalOrganizationService :
        BaseCRUDService<
            PoliticalOrganization,
            PoliticalOrganizationDTO,
            PoliticalOrganizationSearchRequest,
            PoliticalOrganizationRequest,
            PoliticalOrganizationRequest
            >
        , IPoliticalOrganizationService
    {
        public PoliticalOrganizationService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
