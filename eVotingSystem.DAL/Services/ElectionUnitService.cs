using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
namespace eVotingSystem.DAL.Services
{
    public class ElectionUnitService :
        BaseCRUDService<
            ElectionUnit,
            ElectionUnitDTO,
            ElectionUnitSearchRequest,
            ElectionUnitRequest,
            ElectionUnitRequest
            >
        , IElectionUnitService
    {
        public ElectionUnitService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}

