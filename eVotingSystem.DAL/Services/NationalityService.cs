using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;

namespace eVotingSystem.DAL.Services
{
    public class NationalityService :
        BaseCRUDService<
            Nationality,
            NationalityDTO,
            NationalitySearchRequest,
            NationalityRequest,
            NationalityRequest
            >
        , INationalityService
    {
        public NationalityService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
