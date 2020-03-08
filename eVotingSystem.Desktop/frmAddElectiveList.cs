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
    public partial class frmAddElectiveList : Form
    {
        APIService _ElectiveListAPIService = new APIService("ElectiveList");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddElectiveList(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAddElectiveList_Load(object sender, EventArgs e)
        {
            if (cmbElectionRegionId.Items.Count == 0)
            {
                cmbElectionRegionId = await cmbHelper.GetElectionRegions(cmbElectionRegionId);
            }
            if (_id.HasValue)
            {
                var model = await _ElectiveListAPIService.GetById<ElectiveListDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpElectiveList);
                cmbElectionRegionId.SelectedValue = model.ElectionRegionId;
            }
        }

        private async void btnSaveElectiveList(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                
                var request = ControlsHelper.MapControlsToProps(new ElectiveListRequest(), grpElectiveList);
                if (request.ElectionRegionId == 0)
                {
                    lblError.Visible = true;
                    return;
                }
                else
                    lblError.Visible = false;
                if (_id.HasValue)
                {
                    await _ElectiveListAPIService.Update<ElectiveListDTO>(_id.Value, request);
                }
                else
                {
                    await _ElectiveListAPIService.Insert<ElectiveListDTO>(request);
                }

                Hide();
            }
        }
 
    }
}
