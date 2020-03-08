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
    public partial class frmAddCountry : Form
    {
        APIService _countryAPIService = new APIService("Country");
        private int? _id;
        public frmAddCountry(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void btnSave_Click_1(object sender, EventArgs e)
        {
            var request = ControlsHelper.MapControlsToProps(new CountryRequest(), grpCountry);

            if (_id.HasValue)
            {
                await _countryAPIService.Update<CountryDTO>(_id.Value, request);
            }
            else
            {
                await _countryAPIService.Insert<CountryDTO>(request);
            }

            Hide();
        }

        private async void frmAddCountry_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var model = await _countryAPIService.GetById<CountryDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpCountry);
            }
        }
    }
}
