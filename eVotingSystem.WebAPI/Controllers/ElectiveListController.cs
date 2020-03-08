
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectiveListController : BaseController<
        ElectiveList ,
        ElectiveListDTO,
        ElectiveListSearchRequest,
        ElectiveListRequest,
        ElectiveListRequest
        >
    {
        public ElectiveListController(IElectiveListService Service) :
            base(Service)
        {
        }
    }
}