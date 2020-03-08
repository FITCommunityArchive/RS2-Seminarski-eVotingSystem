
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectionUnitController : BaseController<
        ElectionUnit,
        ElectionUnitDTO,
        ElectionUnitSearchRequest,
        ElectionUnitRequest,
        ElectionUnitRequest
        >
    {
        public ElectionUnitController(IElectionUnitService Service) :
            base(Service)
        {
        }
    }
}