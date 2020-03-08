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
    public partial class frmAddCity : Form
    {
        APIService _cityAPIService = new APIService("City");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();

        public frmAddCity(int? id = null)
        {
            InitializeComponent();
            _id = id;

        }


        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new CityRequest(), grpCity);
                if (request.CountryId==0)
                {
                    lblError.Visible = true;
                    return;
                }
                lblError.Visible = false;

                if (_id.HasValue)
                {
                    await _cityAPIService.Update<CityDTO>(_id.Value, request);
                }
                else
                {
                    await _cityAPIService.Insert<CityDTO>(request);
                }

                Hide();
            }
        }
        private async void frmAddCity_Load(object sender, EventArgs e)
        {
            if (cmbCountryId.Items.Count == 0)
            {
                cmbCountryId = await cmbHelper.GetCountries(cmbCountryId);
            }
            if (_id.HasValue)
            {
                var model = await _cityAPIService.GetById<CityDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpCity);
                cmbCountryId.SelectedValue = model.CountryId;
            }
        }
    }
}
