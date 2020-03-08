using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace eVotingSystem.DAL.IServices
{
    public interface IVoteService :
        IBaseCRUDService<
            Vote,
            VoteDTO,
            VoteSearchRequest,
            VoteRequest,
            VoteRequest
            >
    {
        public bool SupposeVote(int elOptionId, string selectedVoterToken,int electiveListId);
        public double GetSimilarityByVotes(List<int> selectedUserVotes, List<int> otherUserVotes);
        public List<int> GetVotesForCandidates(List<ElectionOption> optionsOnLists, string selectedVoterToken);

    }
}
