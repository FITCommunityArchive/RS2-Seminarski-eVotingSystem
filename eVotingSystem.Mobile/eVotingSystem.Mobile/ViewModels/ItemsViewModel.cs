using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using eVotingSystem.Mobile.Models;
using eVotingSystem.Mobile.Views;
using eVotingSystem.CORE.Requests;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using GalaSoft.MvvmLight.Command;

namespace eVotingSystem.Mobile.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();

        public ICommand LoadItemsCommand { get {
                return new Command<ElectiveListDTO>(async (ElectiveListDTO electiveList) => await ExecuteLoadItemsCommand(electiveList));
            }
        }
        public Command PredictVotesCommand { get { 
            return new Command(async () => await PredictVotes()); 
            } }
        public Command SearchCommand
        { get { 
            return new Command(async () => await SearchVotes()); 
            } }
        APIService _VoteService { get; set; } = new APIService("Vote");
        APIService _VoterService { get; set; } = new APIService("Voter");
        APIService _ElectiveListService { get; set; } = new APIService("ElectiveList");
        APIService _ElectionOptionService { get; set; } = new APIService("ElectionOption");
        APIService _CandidateService { get; set; } = new APIService("Candidate");
        APIService _PoliticalOrganizationService { get; set; } = new APIService("PoliticalOrganization");
        List<ElectionOptionDTO> electionOptions;
        List<CandidateDTO>  candidates;
        List<PoliticalOrganizationDTO>  politicalOrganizations;
        private List<VoteDTO> votes;
        ElectiveListDTO _selectedElectiveList = null;

        public ElectiveListDTO SelectedElectiveList
        {
            get { return _selectedElectiveList; }
            set
            {
                if (IsBusy)
                {
                    return;
                }
                SetProperty(ref _selectedElectiveList, value);
                if (value != null)
                {
                    if (Items.Count>0)
                    {
                        Items.Clear();
                    }
                    isSearchEnabled = false;
                    searchedToken = null;
                    Loading = "Loading...";
                    IsPredictEnabled = false;
                    btnText = "Predict Votes";
                    LoadItemsCommand.Execute(_selectedElectiveList);

                }

            }
        }
        private string _loading = null;

        public string Loading
        {
            get { return _loading; }
            set
            {
                //_loading = value;
                SetProperty(ref _loading, value);
            }
        }
        private bool _isSearchEnabled = false;

        public bool isSearchEnabled
        {
            get { return _isSearchEnabled; }
            set
            {
                //_loading = value;
                SetProperty(ref _isSearchEnabled, value);
            }
        }
        private bool _IsNotLoading = true;

        public bool IsNotLoading
        {
            get { return _IsNotLoading; }
            set
            {
                //_loading = value;
                SetProperty(ref _IsNotLoading, value);
            }
        }
        private string _btnText = null;

        public string btnText
        {
            get { return _btnText; }
            set
            {
                SetProperty(ref _btnText, value);
            }
        }
        private string _searchedToken = null;

        public string searchedToken
        {
            get { return _searchedToken; }
            set
            {
                SetProperty(ref _searchedToken, value);
            }
        }

        private string _voted = null;

        public string voted
        {
            get { return _voted; }
            set
            {
                SetProperty(ref _voted, value);
            }
        }

        private string _saldo = null;

        public string saldo
        {
            get { return _saldo; }
            set
            {
                SetProperty(ref _saldo, value);
            }
        }

        bool IsPredictEnabled = false;
        public ICommand InitCommand { get; set; }
        public async Task SearchVotes()
        {
            isSearchEnabled = true;
            Loading = "Loading...";
            ExecuteLoadItemsCommand(_selectedElectiveList);

        }
        public async Task PredictVotes()
        {
            if (IsBusy)
            {
                return;
            }
            IsPredictEnabled = !IsPredictEnabled;
            Loading = "Loading...";
            if (IsPredictEnabled)
            btnText = "Unpredict Votes";
            else
            {
                btnText = "Predict Votes";

            }
            if (Items.Count > 0)
                Items.Clear();
            ExecuteLoadItemsCommand(_selectedElectiveList);
        }

        public ObservableCollection<Guid> NonVotedVoters { get; set; } = new ObservableCollection<Guid>();
        public ItemsViewModel()
        {
            Title = "Votes";
            btnText = "Predict Votes";
            Items = new ObservableCollection<Item>();
            //LoadItemsCommand = new Command<ElectiveListDTO>(async (ElectiveListDTO electiveList) => await ExecuteLoadItemsCommand(electiveList));
            //PredictVotesCommand = new Command(async () => await PredictVotes());
            //InitCommand = new Command(async () => await Init());
            Init();

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
            //loadValues();
        }
        public ObservableCollection<ElectiveListDTO> ElectiveList { get; set; } = new ObservableCollection<ElectiveListDTO>();

        public async Task Init()
        {
            var list = await _ElectiveListService.Get<List<ElectiveListDTO>>(null);
            foreach (var item in list)
            {
                ElectiveList.Add(item);
            }
            Loading = "";
        }
        private async Task loadValues()
        {
            electionOptions = await _ElectionOptionService.Get<List<ElectionOptionDTO>>(null);
            candidates = await _CandidateService.Get<List<CandidateDTO>>(null);
            politicalOrganizations = await _PoliticalOrganizationService.Get<List<PoliticalOrganizationDTO>>(null);
                //IsPredictEnabled = true;
             votes = await _VoteService.Get<List<VoteDTO>>(null);
            var list = await _VoterService.Get <List<VoterDTO>>(null);
            saldo = "Voters:"+list.Count.ToString();
            voted = "Voted:"+list.Where(s => s.IsVoted == true).Count().ToString();

        }

        async Task ExecuteLoadItemsCommand(ElectiveListDTO electiveList)
        {
            if (IsBusy)
            {
                return;
            }
            //orders.Add(await _ordersService.GetById<CountryDTO>(2));
            IsBusy = true;
            IsNotLoading = false;

            await loadValues();

            try
            {
                Items.Clear();
                do
                {
                } while (votes == null);
                if (IsPredictEnabled)
                {
                    Loading += "this takes a while.";
                }
                if (isSearchEnabled && searchedToken!="")
                {
                    //IsPredictEnabled = false;
                    Guid token = Guid.Parse(searchedToken);
                    votes = await _VoteService.Get<List<VoteDTO>>(new VoteSearchRequest() { Token = token });
                    foreach (var item in votes.Where(r => r.ElectiveListId == electiveList.Id && token==r.Token).GroupBy(s => s.ElectionOptionId).Select(q => new { Option = q.Key, Count = q.Count() }).OrderByDescending(r => r.Count))
                    {
                        //VoteDTO vote = item.Option.ToList();
                        string name;
                        var elOption = electionOptions.Find(s => s.Id == item.Option);
                        if (elOption.ElectionOptionType == CORE.Constants.ElectionOptionType.Candidate)
                        {
                            CandidateDTO c = candidates.Find(q => q.Id == elOption.CandidateId);

                            name = c.FirstName + c.LastName;
                        }
                        else
                        {
                            PoliticalOrganizationDTO c = politicalOrganizations.Find(q => q.Id == elOption.PoliticalOrganizationId);
                            name = c.Name;
                        }
                        Items.Add(new Item() { Text = name, Description = item.Count.ToString() + " votes" });
                        searchedToken = "";
                    }
                }
                else
                {
                    foreach (var item in votes.Where(r => r.ElectiveListId == electiveList.Id).GroupBy(s => s.ElectionOptionId).Select(q => new { Option = q.Key, Count = q.Count() }).OrderByDescending(r => r.Count))
                    {
                        //VoteDTO vote = item.Option.ToList();
                        string name;
                        var elOption = electionOptions.Find(s => s.Id == item.Option);
                        if (elOption.ElectionOptionType == CORE.Constants.ElectionOptionType.Candidate)
                        {
                            CandidateDTO c = candidates.Find(q => q.Id == elOption.CandidateId);

                            name = c.FirstName + c.LastName;
                        }
                        else
                        {
                            PoliticalOrganizationDTO c = politicalOrganizations.Find(q => q.Id == elOption.PoliticalOrganizationId);
                            name = c.Name;
                        }
                        ///collaborative filtering prediction of votes
                        NonVotedVoters.Clear();
                        if (IsPredictEnabled)
                        {
                            var otherElectionListsVotes = votes.Where(r => r.ElectiveListId != electiveList.Id).GroupBy(q => q.Token);
                            foreach (var voter in otherElectionListsVotes)
                            {
                                NonVotedVoters.Add(voter.Key);
                            }
                        }
                        if (NonVotedVoters.Count != 0)
                        {
                            int predictedVotes = 0;
                            foreach (var selectedVoter in NonVotedVoters)
                            {
                                bool wouldVote = await _VoteService.SupposeVote(item.Option, selectedVoter.ToString(), _selectedElectiveList.Id);
                                predictedVotes += wouldVote ? 1 : 0;
                            }
                            Items.Add(new Item() { Text = name, Description = item.Count.ToString() + " votes - possible predicted:" + predictedVotes });
                        }
                        else
                            Items.Add(new Item() { Id= elOption.Id, Text = name, Description = item.Count.ToString() + " votes" });
                    }
                }
                Loading = "Loaded!";

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
                IsNotLoading = true;
            }
        }
    }
}