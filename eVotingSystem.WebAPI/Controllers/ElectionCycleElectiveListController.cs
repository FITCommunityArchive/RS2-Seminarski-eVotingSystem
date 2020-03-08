
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectionCycleElectiveListController : BaseController<
        ElectionCycleElectiveList,
        ElectionCycleElectiveListDTO,
        ElectionCycleElectiveListSearchRequest,
        ElectionCycleElectiveListRequest,
        ElectionCycleElectiveListRequest
        >
    {
        public ElectionCycleElectiveListController(IElectionCycleElectiveListService Service) :
            base(Service)
        {
        }
    }
}