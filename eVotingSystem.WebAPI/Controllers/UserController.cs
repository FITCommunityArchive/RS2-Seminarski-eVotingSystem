
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController<
        User,
        UserDTO,
        UserSearchRequest,
        UserRequest,
        UserRequest
        >
    {
        public UserController(IUserService Service) :
            base(Service)
        {
        }
    }
}