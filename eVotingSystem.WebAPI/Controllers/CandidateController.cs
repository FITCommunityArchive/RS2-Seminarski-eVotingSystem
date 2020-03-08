
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : BaseController<
        Candidate,
        CandidateDTO,
        CandidateSearchRequest,
        CandidateRequest,
        CandidateRequest
        >
    {
        public CandidateController(ICandidateService Service) :
            base(Service)
        {
        }
    }
}