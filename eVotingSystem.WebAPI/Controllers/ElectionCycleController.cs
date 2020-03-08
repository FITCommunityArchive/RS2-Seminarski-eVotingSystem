
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectionCycleController : BaseController<
        ElectionCycle,
        ElectionCycleDTO,
        ElectionCycleSearchRequest,
        ElectionCycleRequest,
        ElectionCycleRequest
        >
    {
        public ElectionCycleController(IElectionCycleService Service) :
            base(Service)
        {
        }
    }
}