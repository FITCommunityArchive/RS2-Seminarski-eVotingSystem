
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PoliticalOrganizationController : BaseController<
        PoliticalOrganization,
        PoliticalOrganizationDTO,
        PoliticalOrganizationSearchRequest,
        PoliticalOrganizationRequest,
        PoliticalOrganizationRequest
        >
    {
        public PoliticalOrganizationController(IPoliticalOrganizationService Service) :
            base(Service)
        {
        }
    }
}