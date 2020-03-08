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
    public partial class frmAddNationality : Form
    {
        APIService _nationalityAPIService = new APIService("Nationality");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddNationality(int? id = null)
        {
            InitializeComponent();
            _id = id;

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new NationalityRequest(), grpNationality);

                if (_id.HasValue)
                {
                    await _nationalityAPIService.Update<NationalityDTO>(_id.Value, request);
                }
                else
                {
                    await _nationalityAPIService.Insert<NationalityDTO>(request);
                }

                Hide();
            }
        }

        private async void frmAddNationality_Load(object sender, EventArgs e)
        {
            if (_id.HasValue)
            {
                var model = await _nationalityAPIService.GetById<NationalityDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpNationality);
            }
        }
    }
}
