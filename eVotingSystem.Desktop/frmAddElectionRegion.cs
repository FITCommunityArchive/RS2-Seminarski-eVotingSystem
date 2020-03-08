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
    public partial class frmAddElectionRegion : Form
    {
        APIService _ElectionRegionAPIService = new APIService("ElectionRegion");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddElectionRegion(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAddElectionRegion_Load(object sender, EventArgs e)
        {
            if (cmbSuperiorRegionId.Items.Count == 0)
            {
                cmbSuperiorRegionId = await cmbHelper.GetElectionRegions(cmbSuperiorRegionId);
            }
            if (_id.HasValue)
            {
                var model = await _ElectionRegionAPIService.GetById<ElectionRegionDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpElectionRegion);
                cmbSuperiorRegionId.SelectedValue = model.SuperiorElectionRegionDTOId;
            }
        }

        private async void btnSaveElectionRegion(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new ElectionRegionRequest(), grpElectionRegion);
                if (request.SuperiorElectionRegionDTOId == 0)
                {
                    request.SuperiorElectionRegionDTOId = null;
                }
                if (_id.HasValue)
                {
                    await _ElectionRegionAPIService.Update<ElectionRegionDTO>(_id.Value, request);
                }
                else
                {
                    await _ElectionRegionAPIService.Insert<ElectionRegionDTO>(request);
                }

                Hide();
            }
        }

    }
}
