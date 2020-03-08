using eVotingSystem.CORE.Constants;
using eVotingSystem.CORE.Models;
using eVotingSystem.CORE.Requests;
using eVotingSystem.DAL.EF;
using eVotingSystem.WebAPI.Controllers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eVotingSystem.WebAPI.Util
{
    public class Recommender
    {

        eVotingSystemDbContext db = new eVotingSystemDbContext(null);
        public bool SupposeVote(int elOptionId,Guid selectedVoterToken)
        {
            ///votes by selected voter
            List<Vote> VotesBySelectedVoter= db.Votes.Where(s => s.Token == selectedVoterToken).ToList();
            ///end
            
            ///lists which are already voted by voter 
            List<int> ListsVotedBySelectedVoter= new List<int>();
            foreach (var item in VotesBySelectedVoter)
            {
                ListsVotedBySelectedVoter.Add(item.ElectiveListId);
            }
            ///end
            
            ///optionst which are available on elected lists
            List<ElectionOption> optionsOnLists = new List<ElectionOption>();
            foreach (var item in ListsVotedBySelectedVoter)
            {
                foreach (var elOption in db.ElectiveListElectionOptions.Where(q=>q.ElectiveListId==item))
                {
                    optionsOnLists.Add(db.ElectionOptions.First(s=>s.Id== elOption.ElectionOptionId));
                }
            }
            ///end

            ///votes by selected user
            List<int> generatedVotesForCandidatesBySelectedUser = GetVotesForCandidates(optionsOnLists, selectedVoterToken);

            

            List<Vote> VotesByOtherUsers = db.Votes.Where(s => s.Token != selectedVoterToken).ToList();
            List<Guid> otherVoterTokens = new List<Guid>();
            foreach (var item in VotesByOtherUsers)
            {
                if (!otherVoterTokens.Contains(item.Token))
                    otherVoterTokens.Add(item.Token);
            }

            List<List<int>> generatedVotesForCandidatesByOtherUsers = new List< List<int>>();
            foreach (var item in otherVoterTokens)
            {
                var votes=GetVotesForCandidates(optionsOnLists, item);

                generatedVotesForCandidatesByOtherUsers.Add(votes);
            }

            Dictionary<Guid,double> similaritesToSelectedUser = new Dictionary<Guid, double> ();
            foreach (var voterToken in otherVoterTokens)
            {
                foreach (var e in generatedVotesForCandidatesByOtherUsers)
                {
                    similaritesToSelectedUser.Add(voterToken,GetSimilarityByVotes(generatedVotesForCandidatesBySelectedUser,generatedVotesForCandidatesBySelectedUser));
                }
            }
            similaritesToSelectedUser.OrderByDescending(s => s.Value);


            return db.Votes.First(s => s.ElectionOptionId == elOptionId && s.Token == similaritesToSelectedUser.Keys.FirstOrDefault()).ElectionOptionId==elOptionId;

        }
        public double GetSimilarityByVotes(List<int> selectedUserVotes,List<int> otherUserVotes)
        {
            double upper = 0;
            double lower1 = 0;
            double lower2 = 0;
            for (int i = 0; i < selectedUserVotes.Count; i++)
            {
                if (selectedUserVotes[i]== otherUserVotes[i])
                {
                    upper++;
                }

            }
            return upper / selectedUserVotes.Count;
        }

        public List<int> GetVotesForCandidates(List<ElectionOption> optionsOnLists, Guid selectedVoterToken)
        {
            List< int> votesByCandidatesForSelectedVoter = new List<int>();
            foreach (var item in optionsOnLists)
            {
                if (db.Votes.Where(q => q.ElectionOptionId == item.Id && q.Token == selectedVoterToken).FirstOrDefault() != null)
                    votesByCandidatesForSelectedVoter.Add(1);
                else
                    votesByCandidatesForSelectedVoter.Add(0);
            }

            return votesByCandidatesForSelectedVoter;

        }
    }
}
