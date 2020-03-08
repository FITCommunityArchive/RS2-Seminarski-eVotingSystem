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
    public partial class frmAddVoter : Form
    {
        APIService _VoterAPIService = new APIService("Voter");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddVoter(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAddVoter_Load(object sender, EventArgs e)
        {
            if (cmbGender.Items.Count == 0)
            {
                cmbGender = await cmbHelper.GetGenders(cmbGender);
            }
            if (cmbSchoolingDegreeLevel.Items.Count == 0)
            {
                cmbSchoolingDegreeLevel = await cmbHelper.GetSchoolingDegrees(cmbSchoolingDegreeLevel);
            }
            if (cmbUserId.Items.Count == 0)
            {
                cmbUserId = await cmbHelper.GetUsers(cmbUserId);
            }
            if (cmbNationalityId.Items.Count == 0)
            {
                cmbNationalityId = await cmbHelper.GetNationalities(cmbNationalityId);
            }
            //if (_id.HasValue)
            //{
            //    var model = await _cityAPIService.GetById<CityDTO>(_id.Value);
            //    ControlsHelper.MapPropsToControls(model, grpCity);
            //    cmbCountryId.SelectedValue = model.CountryId;
            //}
        }

        private async void btnSaveVoter(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new VoterRequest(), grpVoter);
                if (request.UserId == 0)
                {
                    lblError.Visible = true;
                    return;
                }
                lblError.Visible = false;

                if (request.NationalityId == 0)
                    request.NationalityId = null;
                    if (_id.HasValue)
                {
                    await _VoterAPIService.Update<VoterDTO>(_id.Value, request);
                }
                else
                {
                    await _VoterAPIService.Insert<VoterDTO>(request);
                }

                Hide();
            }
        }


    }
}
