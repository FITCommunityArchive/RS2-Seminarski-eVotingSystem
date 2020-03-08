
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseController<
        Country,
        CountryDTO,
        CountrySearchRequest,
        CountryRequest,
        CountryRequest
        >
    {
        public CountryController(ICountryService CountryService) :
            base(CountryService)
        {
        }
    }
}