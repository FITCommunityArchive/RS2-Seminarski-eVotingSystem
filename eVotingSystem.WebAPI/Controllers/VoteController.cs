
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using Microsoft.AspNetCore.Mvc;
using System;

namespace eVotingSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : BaseController<
        Vote,
        VoteDTO,
        VoteSearchRequest,
        VoteRequest,
        VoteRequest
        >
    {
        IVoteService voteService;
        public VoteController(IVoteService Service) :
            base(Service)
        {
            voteService = Service;
        }
        [HttpGet]
        [Route("GetRecommendedVotes")]
        public virtual bool GetRecommendedVotes([FromQuery]int electionOptionId, [FromQuery]string voterToken,[FromQuery] int electiveListId)
        {
            return voteService.SupposeVote(electionOptionId, voterToken, electiveListId);
        }
    }
}