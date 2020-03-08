
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoterController : BaseController<
        Voter,
        VoterDTO,
        VoterSearchRequest,
        VoterRequest,
        VoterRequest
        >
    {
        public VoterController(IVoterService Service) :
            base(Service)
        {
        }
    }
}