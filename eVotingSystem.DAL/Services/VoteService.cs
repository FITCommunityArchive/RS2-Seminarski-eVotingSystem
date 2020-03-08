using AutoMapper;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.IServices;
using eVotingSystem.DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eVotingSystem.DAL.Services
{
    public class VoteService :
        BaseCRUDService<
            Vote,
            VoteDTO,
            VoteSearchRequest,
            VoteRequest,
            VoteRequest
            >
        , IVoteService
    {
        eVotingSystemDbContext db;
        public VoteService(
            eVotingSystemDbContext dbContext,
            IMapper mapper) :
            base(dbContext, mapper)
        {
            db = dbContext;
        }
        public bool SupposeVote(int elOptionId, string selectedVoterToken,int electiveListId)
        {
            ///votes by selected voter
            List<Vote> VotesBySelectedVoter = db.Votes.Where(s => s.Token.ToString() == selectedVoterToken).ToList();
            ///end

            ///lists which are already voted by voter 
            List<int> ListsVotedBySelectedVoter = new List<int>();
            foreach (var item in VotesBySelectedVoter)
            {
                ListsVotedBySelectedVoter.Add(item.ElectiveListId);
            }
            ///end

            ///optionst which are available on elected lists
            List<ElectionOption> optionsOnLists = new List<ElectionOption>();
            foreach (var item in ListsVotedBySelectedVoter)
            {
                foreach (var elOption in db.ElectiveListElectionOptions.Where(q => q.ElectiveListId == item))
                {
                    optionsOnLists.Add(db.ElectionOptions.First(s => s.Id == elOption.ElectionOptionId));
                }
            }
            ///end

            ///votes by selected user
            List<int> generatedVotesForCandidatesBySelectedUser = GetVotesForCandidates(optionsOnLists, selectedVoterToken);

            List<Vote> VotesByOtherUsers = db.Votes.Where(s => s.Token.ToString() != selectedVoterToken && s.ElectiveListId== electiveListId).ToList();
            List<Guid> otherVoterTokens = new List<Guid>();
            foreach (var item in VotesByOtherUsers)
            {
                if (!otherVoterTokens.Contains(item.Token))
                    otherVoterTokens.Add(item.Token);
            }

            List<List<int>> generatedVotesForCandidatesByOtherUsers = new List<List<int>>();
            foreach (var item in otherVoterTokens)
            {
                var votes = GetVotesForCandidates(optionsOnLists, item.ToString());

                generatedVotesForCandidatesByOtherUsers.Add(votes);
            }

            Dictionary<Guid, double> similaritesToSelectedUser = new Dictionary<Guid, double>();
            for (int i = 0; i < otherVoterTokens.Count; i++)
            {
                    similaritesToSelectedUser.Add(otherVoterTokens[i], GetSimilarityByVotes(generatedVotesForCandidatesBySelectedUser, generatedVotesForCandidatesByOtherUsers[i]));
            }
            var sorted= similaritesToSelectedUser.OrderByDescending(s => s.Value);
            double topSimilarityVotesSum = 0;
            int increment=0;
            foreach (var item in sorted)
            {
                if (increment>3)
                {
                    break;
                }
                if (item.Value>0)
                {
                    bool wouldVote=( db.Votes.Where(s => s.ElectionOptionId == elOptionId && s.Token == item.Key && s.ElectiveListId==electiveListId).FirstOrDefault() != null );
                    topSimilarityVotesSum += wouldVote ? item.Value* 1 :item.Value* -1;
                }
                increment++;
            }
            if (sorted.Count()==0)
            {
                return false;
            }
            return (topSimilarityVotesSum > 0.5)?true:false;

        }
        public double GetSimilarityByVotes(List<int> selectedUserVotes, List<int> otherUserVotes)
        {
            double upper = 0;
            for (int i = 0; i < selectedUserVotes.Count; i++)
            {
                if (selectedUserVotes[i] == otherUserVotes[i])
                {
                    upper++;
                }
                else
                    upper--;
            }
            return upper / selectedUserVotes.Count;
        }

        public List<int> GetVotesForCandidates(List<ElectionOption> optionsOnLists, string selectedVoterToken)
        {
            List<int> votesByCandidatesForSelectedVoter = new List<int>();
            foreach (var item in optionsOnLists)
            {
                if (db.Votes.Where(q => q.ElectionOptionId == item.Id && q.Token.ToString() == selectedVoterToken).FirstOrDefault() != null)
                    votesByCandidatesForSelectedVoter.Add(1);
                else
                    votesByCandidatesForSelectedVoter.Add(-1);
            }

            return votesByCandidatesForSelectedVoter;

        }
    }
}