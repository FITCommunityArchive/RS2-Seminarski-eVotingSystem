
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : BaseController<
        Message,
        MessageDTO,
        MessageSearchRequest,
        MessageRequest,
        MessageRequest
        >
    {
        public MessageController(IMessageService Service) :
            base(Service)
        {
        }
    }
}