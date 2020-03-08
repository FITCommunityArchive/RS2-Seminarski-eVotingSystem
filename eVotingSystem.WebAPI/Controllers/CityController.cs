
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : BaseController<
        City,
        CityDTO,
        CitySearchRequest,
        CityRequest,
        CityRequest
        >
    {
        public CityController(ICityService CityService) :
            base(CityService)
        {
        }
    }
}