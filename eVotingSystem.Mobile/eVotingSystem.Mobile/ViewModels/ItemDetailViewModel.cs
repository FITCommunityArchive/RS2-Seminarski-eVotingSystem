using System;
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

using eVotingSystem.Mobile.Models;

namespace eVotingSystem.Mobile.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ICommand LoadItemsCommand
        {
            get
            {
                return new Command<ElectiveListDTO>(async (ElectiveListDTO electiveList) => await ExecuteLoadItemsCommand(electiveList));
            }
        }
        APIService _VoteService { get; set; } = new APIService("Vote");
        APIService _FileService { get; set; } = new APIService("File");
        APIService _VoterService { get; set; } = new APIService("Voter");
        APIService _ElectiveListService { get; set; } = new APIService("ElectiveList");
        APIService _ElectionOptionService { get; set; } = new APIService("ElectionOption");
        APIService _CandidateService { get; set; } = new APIService("Candidate");
        APIService _PoliticalOrganizationService { get; set; } = new APIService("PoliticalOrganization");
        APIService _ElectionUnitService { get; set; } = new APIService("ElectionUnit");
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
            Items = new ObservableCollection<Item>();

        }
        List<ElectionOptionDTO> electionOptions;
        List<CandidateDTO> candidates;
        List<PoliticalOrganizationDTO> politicalOrganizations;
        private List<VoteDTO> votes;
        private List<ElectionUnitDTO> units;
        ElectiveListDTO _selectedElectiveList = null;

        public ObservableCollection<Item> Items { get; set; }

        private async Task loadValues()
        {
            electionOptions = await _ElectionOptionService.Get<List<ElectionOptionDTO>>(null);
            candidates = await _CandidateService.Get<List<CandidateDTO>>(null);
            politicalOrganizations = await _PoliticalOrganizationService.Get<List<PoliticalOrganizationDTO>>(null);
            units = await _ElectionUnitService.Get<List<ElectionUnitDTO>>(null);
            //IsPredictEnabled = true;
            votes = await _VoteService.Get<List<VoteDTO>>(null);
        }
        async Task ExecuteLoadItemsCommand(ElectiveListDTO electiveList)
        {
            if (IsBusy)
            {
                return;
            }
            //orders.Add(await _ordersService.GetById<CountryDTO>(2));
            IsBusy = true;

            await loadValues();

            try
            {
                Items.Clear();
                do
                {
                } while (votes == null);
                //IsPredictEnabled = false;
                {
                    foreach (var item in votes.Where(r => r.ElectionOptionId == Item.Id).GroupBy(s => s.ElectionUnitId).Select(q => new { Option = q.Key, Count = q.Count() }).OrderByDescending(r => r.Count))
                    {
                        //VoteDTO vote = item.Option.ToList();
                        string name;
                        var elOption = units.Find(s => s.Id == item.Option);
                        //var elOption2 = electionOptions.Find(s => s.Id == Item.Id);
                        //if (elOption2.ElectionOptionType == CORE.Constants.ElectionOptionType.Candidate)
                        //{
                        //    var pic = candidates.Find(q => q.Id==elOption2.CandidateId);
                        //    var a = await _FileService.Get<FileDTO>(new FileSearchRequest() { Id == pic.PictureId})
                        //var file = await _fileSystemService.GetFile(p);

                        //    var stream1 = new MemoryStream(file);
                        //    IncidentImageData.Source = ImageSource.FromStream(() => stream1);
                        //}
                        //else
                        //{
                        //    var pic= politicalOrganizations.Find(q => q.Id==elOption2.PoliticalOrganizationId);
                        //    var a = await _FileService.Get<FileDTO>(new FileSearchRequest() { Id == elOption2.})
                        //var file = await _fileSystemService.GetFile(p);

                        //    var stream1 = new MemoryStream(file);
                        //    IncidentImageData.Source = ImageSource.FromStream(() => stream1);

                        //}


                        //if (elOption.ElectionOptionType == CORE.Constants.ElectionOptionType.Candidate)
                        //{
                        //    CandidateDTO c = candidates.Find(q => q.Id == elOption.CandidateId);

                        //    name = c.FirstName + c.LastName;
                        //}
                        //else
                        //{
                        //    PoliticalOrganizationDTO c = politicalOrganizations.Find(q => q.Id == elOption.PoliticalOrganizationId);
                        //    name = c.Name;
                        //}
                        ///collaborative filtering prediction of votes

                        Items.Add(new Item() { Text = elOption.Name, Description = item.Count.ToString() + " votes" });
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
