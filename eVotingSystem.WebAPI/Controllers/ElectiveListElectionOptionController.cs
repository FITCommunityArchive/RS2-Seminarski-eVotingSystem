
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectiveListElectionOptionController : BaseController<
        ElectiveListElectionOption,
        ElectiveListElectionOptionDTO,
        ElectiveListElectionOptionSearchRequest,
        ElectiveListElectionOptionRequest,
        ElectiveListElectionOptionRequest
        >
    {
        public ElectiveListElectionOptionController(IElectiveListElectionOptionService Service) :
            base(Service)
        {
        }
    }
}