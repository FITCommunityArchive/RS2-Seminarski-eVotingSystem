
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectionOptionController : BaseController<
        ElectionOption,
        ElectionOptionDTO,
        ElectionOptionSearchRequest,
        ElectionOptionRequest,
        ElectionOptionRequest
        >
    {
        public ElectionOptionController(IElectionOptionService Service) :
            base(Service)
        {
        }
    }
}