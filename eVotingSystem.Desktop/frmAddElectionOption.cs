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
    public partial class frmAddElectionOption : Form
    {
        APIService _ElectionOptionAPIService = new APIService("ElectionOption");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddElectionOption(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAddElectionOption_Load(object sender, EventArgs e)
        {

            if (cmbCandidateId.Items.Count == 0)
            {
                cmbCandidateId = await cmbHelper.GetCandidates(cmbCandidateId);
            }
            if (_id.HasValue)
            {
                var model = await _ElectionOptionAPIService.GetById<ElectionOptionDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpElectionOption);
                cmbCandidateId.SelectedValue = model.CandidateId;
            }
            
            if (cmbElectionOptionType.Items.Count == 0)
            {
                cmbElectionOptionType = await cmbHelper.GetElectionOptionTypes(cmbElectionOptionType);
            }
            if (_id.HasValue)
            {
                var model = await _ElectionOptionAPIService.GetById<ElectionOptionDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpElectionOption);
                cmbElectionOptionType.SelectedValue = model.ElectionOptionType;
            }
            
            if (cmbElectiveListId.Items.Count == 0)
            {
                cmbElectiveListId = await cmbHelper.GetElectiveLists(cmbElectiveListId);
            }
            if (_id.HasValue)
            {
                APIService _ElectiveListElectionOptionAPIService = new APIService("ElectiveListElectionOption");
                var model = await _ElectiveListElectionOptionAPIService.Get<ElectiveListElectionOptionDTO>(new ElectiveListElectionOptionSearchRequest() { ElectionOptionId=_id.Value });
                ControlsHelper.MapPropsToControls(model, grpElectionOption);
                cmbElectiveListId.SelectedValue = model.ElectiveListId;
            }
            
            if (cmbPoliticalOrganizationId.Items.Count == 0)
            {
                cmbPoliticalOrganizationId = await cmbHelper.GetPoliticalOrganizations(cmbPoliticalOrganizationId);
            }
            if (_id.HasValue)
            {
                var model = await _ElectionOptionAPIService.GetById<ElectionOptionDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpElectionOption);
                cmbPoliticalOrganizationId.SelectedValue = model.PoliticalOrganizationId;
            }

        }

        private async void btnSaveElectionOption(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var selectedPO = (ComboBoxItem)cmbPoliticalOrganizationId.SelectedItem;
                var selectedCandidate = (ComboBoxItem)cmbCandidateId.SelectedItem;
                var selectedEOT = (ComboBoxItem)cmbElectionOptionType.SelectedItem;
                var selectedList =(ComboBoxItem)cmbElectiveListId.SelectedItem;
                int? POId=null;
                int? CId=null;
                int EOTId=0;
                if (selectedPO!=null)
                    POId = selectedPO.Value;
                if (selectedCandidate!=null)
                    CId = selectedCandidate.Value;
                if (selectedEOT != null)
                    EOTId = selectedEOT.Value;
                if (selectedEOT == null || selectedList==null || (selectedCandidate == null && selectedPO == null))
                {
                    lblError.Visible = true;
                    return;
                }
                else
                    lblError.Visible = false ;
                var request = new ElectionOptionRequest() { PoliticalOrganizationId =  POId,CandidateId=CId, ElectionOptionType=(ElectionOptionType)EOTId };
                //var request = ControlsHelper.MapControlsToProps(new ElectionOptionRequest(), grpElectionOption);
                ElectionOptionDTO response=new ElectionOptionDTO();
                if (_id.HasValue)
                {
                    response=await _ElectionOptionAPIService.Update<ElectionOptionDTO>(_id.Value, request);
                }
                else
                {
                    response=await _ElectionOptionAPIService.Insert<ElectionOptionDTO>(request);
                }
                APIService _ElectiveListElectionOptionAPIService = new APIService("ElectiveListElectionOption");
                
                await _ElectiveListElectionOptionAPIService.Insert<ElectiveListElectionOptionDTO>(new ElectiveListElectionOptionSearchRequest() { ElectionOptionId=response.Id,ElectiveListId=selectedList.Value});

                Hide();
            }
        }

        private void cmbElectionOptionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEOT = (ComboBoxItem)cmbElectionOptionType.SelectedItem;
            if (selectedEOT.Value == (int)ElectionOptionType.Candidate)
            {
                cmbPoliticalOrganizationId.Enabled = false;
                cmbCandidateId.Enabled = true;
            }
            else
            {
                cmbCandidateId.Enabled = false;
                cmbPoliticalOrganizationId.Enabled = true;
            }
        }
    }
}
