using eVotingSystem.CORE.Constants;
using eVotingSystem.CORE.Requests;
using eVotingSystem.Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVotingSystem.Desktop
{
    public partial class frmVote : Form
    {
        APIService _voteAPIService = new APIService("Vote");
        APIService _ElectionOptionAPIService = new APIService("ElectionOption");

        APIService _VoterAPIService = new APIService("Voter");
        APIService _ElectiveListElectionOptionAPIService = new APIService("ElectiveListElectionOption");

        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmVote(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmVote_Load(object sender, EventArgs e)
        {
            //if (cmbCountryId.Items.Count == 0)
            //{
            cmbElectiveListId = await cmbHelper.GetElectiveLists(cmbElectiveListId, (int)APIService.CurrentUser.ElectionUnitId);
            //cmbPoliticalOrganizationId = await cmbHelper.GetElectiveListElectionOptions(cmbPoliticalOrganizationId);
            //}
            //if (_id.HasValue)
            //{
            //    var model = await _cityAPIService.GetById<CityDTO>(_id.Value);
            //    ControlsHelper.MapPropsToControls(model, grpCity);
            //    cmbCountryId.SelectedValue = model.CountryId;
            //}

        }

        private async void btnVote_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                //var request = ControlsHelper.MapControlsToProps(new VoteRequest(), grpVote);
                ComboBoxItem selectedPO = (ComboBoxItem)cmbElectiveListId.SelectedItem;
                ComboBoxItem selectedEL = (ComboBoxItem)cmbElectiveListId.SelectedItem;
                if (selectedEL == null || (selectedPO==null && selectedItems.Count == 0))
                {
                    lblError.Visible = true;
                    return;
                }
                lblError.Visible = false;
                //if (_id.HasValue)
                //{
                //    if (cmbElectionOptionId.SelectedItem != null)
                //        await _voteAPIService.Update<VoteDTO>(_id.Value, selectedPO.Value);
                //}
                //else
                //{

                //}

                List<VoterDTO> voter = await _VoterAPIService.Get<List<VoterDTO>>(new VoterSearchRequest() { UserId = APIService.CurrentUser.Id });
                ComboBoxItem a = (ComboBoxItem)cmbElectiveListId.SelectedItem;

                if (voter.Count != 0 || voter[0].IsVoted == true)
                {
                    foreach (KeyValuePair<int, string> item in selectedItems)
                    {
                        //APIService _ElectionOptionAPIService = new APIService("ElectionOption");
                        if (item.Value != null)
                        {
                            var c = await _ElectionOptionAPIService.Get<List<ElectionOptionDTO>>(new ElectionOptionSearchRequest() { CandidateId = item.Key, ElectionOptionType = ElectionOptionType.Candidate });
                            VoteRequest v = new VoteRequest() { ElectionOptionId = c[0].Id, ElectionUnitId = APIService.CurrentUser.ElectionUnitId, VoterCityId = APIService.CurrentUser.CityId, NationalityId = voter[0].NationalityId, ElectiveListId = a.Value, Gender = voter[0].Gender, SchoolingDegreeLevel = voter[0].SchoolingDegreeLevel, TimeOfVoting = DateTime.Now, Token = APIService.Token };
                            await _voteAPIService.Insert<VoteDTO>(v);
                        }
                    }
                }
                else
                {
                    lblError.Visible = true;
                    return;
                }
                if (cmbElectionOptionId.SelectedItem != null)
                {
                    await _voteAPIService.Insert<VoteDTO>(new VoteRequest() { ElectionOptionId = selectedPO.Value, ElectionUnitId = APIService.CurrentUser.ElectionUnitId, VoterCityId = APIService.CurrentUser.CityId, NationalityId = voter[0].NationalityId, ElectiveListId = a.Value, Gender = voter[0].Gender, SchoolingDegreeLevel = voter[0].SchoolingDegreeLevel, TimeOfVoting = DateTime.Now, Token = APIService.Token });
                }
                            await _VoterAPIService.Update<VoterDTO>(voter[0].Id, new VoterRequest() { IsVoted = true ,UserId=voter[0].UserId, Gender=voter[0].Gender, NationalityId= voter[0].NationalityId, SchoolingDegreeLevel=voter[0].SchoolingDegreeLevel,  Id=voter[0].Id});
                Hide();
            }
        }
        List<KeyValuePair<int,string>> selectedItems = new List<KeyValuePair<int, string>>();
        private void chkCandidates_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (selectedItems.Contains((KeyValuePair<int, string>)chkCandidates.Items[e.Index]))
                selectedItems.Remove((KeyValuePair<int, string>)chkCandidates.Items[e.Index]);
            else
                selectedItems.Add((KeyValuePair<int, string>)chkCandidates.Items[e.Index]);
        }

        private async void cmbElectiveListId_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbElectiveListId.SelectedItem!=null)
            {
                ComboBoxItem a = (ComboBoxItem)cmbElectiveListId.SelectedItem;
                
                cmbElectionOptionId = await cmbHelper.GetElectiveListElectionOptions(cmbElectionOptionId, a.Value);
                cmbElectionOptionId.Enabled = true;
                
                APIService _ElectiveListElectionOptionAPIService = new APIService("ElectiveListElectionOption");
                List<ElectiveListElectionOptionDTO> selectedListElectionOptions = await _ElectiveListElectionOptionAPIService.Get<List<ElectiveListElectionOptionDTO>>(new ElectiveListElectionOptionSearchRequest() { ElectiveListId = a.Value });
                List<CandidateDTO> candidates= new List<CandidateDTO>();
                APIService _CandidateAPIService = new APIService("Candidate");
                var dict = new Dictionary<int, string>();
                APIService _ElectionOptionAPIService = new APIService("ElectionOption");
                foreach (var selectedOption in selectedListElectionOptions)
                {
                    List<ElectionOptionDTO> elOptions = await _ElectionOptionAPIService.Get<List<ElectionOptionDTO>>(new ElectionOptionSearchRequest() { Id = selectedOption.ElectionOptionId });
                    foreach (var elOption in elOptions)
                    {
                        if (elOption.ElectionOptionType == 0)
                        {
                            candidates = await _CandidateAPIService.Get<List<CandidateDTO>>(new CandidateSearchRequest() { Id = (int)elOption.CandidateId });
                            foreach (var item in candidates)
                            {
                                dict.Add(item.Id, item.FirstName + " " + item.LastName);
                            }
                        }
                    }
                }
                //List<ElectionOptionDTO> electionOptionsCandidates = new List<ElectionOptionDTO>();
                //foreach (var item in selectedListElectionOptions)
                //{
                //    APIService _ElectionOptionAPIService = new APIService("ElectionOption");
                //    electionOptionsCandidates.AddRange( await _ElectionOptionAPIService.Get<List<ElectionOptionDTO>>(new ElectionOptionSearchRequest() { Id= item.ElectionOptionId }));
                //}
                //if (electionOptionsCandidates == null)
                //{
                //    return;
                //}
                //APIService _CandidateAPIService = new APIService("Candidate");
                //List<CandidateDTO> temp = new List<CandidateDTO>();
                //var dict = new Dictionary<int, string>();
                //foreach (var item in candidates)
                //{ 
                //    if ((int)item.ElectionOptionType == 2)
                //    {
                //        var cans = await _CandidateAPIService.Get<List<CandidateDTO>>(new CandidateSearchRequest() { Id = (int)item.CandidateId });
                //        temp.AddRange(cans);
                //        foreach (var item2 in temp)
                //        {
                //            dict.Add(item2.Id, item2.FirstName +" "+ item2.LastName);
                //        }
                //    }
                //}
                if (dict.Count!=0)
                {
                chkCandidates.DataSource = new BindingSource(dict, null);

                chkCandidates.DisplayMember = "Value";
                chkCandidates.ValueMember = "Key";
                chkCandidates.Enabled = true;

                chkCandidates.ClearSelected();
                }
            }

            //List<ElectiveListElectionOptionDTO> electionOptions = await _ElectiveListElectionOptionAPIService.Get<List<ElectiveListElectionOptionDTO>>(new ElectiveListElectionOptionSearchRequest() { ElectiveListId = (int)cmbElectiveListId.SelectedValue });
            //List<PoliticalOrganizationDTO>
            //cmbPoliticalOrganizationId = await cmbHelper.GetPoliticalOrganizations(cmbPoliticalOrganizationId);
            //APIService _CandidateAPIService = new APIService("Candidate");
            //chkCandidates.DataSource = await _CandidateAPIService.Get<List<CandidateDTO>>(null);

            //chkCandidates.DisplayMember = "FirstName" + " " + "LastName";
            //chkCandidates.ClearSelected();
        }
    }
}
