using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
namespace eVotingSystem.DAL.Services
{
    public class MessageService :
        BaseCRUDService<
            Message,
            MessageDTO,
            MessageSearchRequest,
            MessageRequest,
            MessageRequest
            >
        , IMessageService
    {
        public MessageService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        { }
    }
}
