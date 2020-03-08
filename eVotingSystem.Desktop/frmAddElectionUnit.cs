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
    public partial class frmAddElectionUnit : Form
    {
        APIService _ElectionUnitAPIService = new APIService("ElectionUnit");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddElectionUnit(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async  void frmAddElectionUnit_Load(object sender, EventArgs e)
        {
            if (cmbElectionRegionId.Items.Count == 0)
            {
                cmbElectionRegionId = await cmbHelper.GetElectionRegions(cmbElectionRegionId);
            }
            if (_id.HasValue)
            {
                var model = await _ElectionUnitAPIService.GetById<ElectionUnitDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpElectionUnit);
                cmbElectionRegionId.SelectedValue = model.ElectionRegionId;
            }
        }

        private async void btnSaveElectionUnit(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new ElectionUnitRequest(), grpElectionUnit);
                if (request.ElectionRegionId == 0)
                {
                    lblError.Visible = true;
                    return;
                }
                else
                    lblError.Visible = false;
                if (_id.HasValue)
                {
                    await _ElectionUnitAPIService.Update<ElectionUnitDTO>(_id.Value, request);
                }
                else
                {
                    await _ElectionUnitAPIService.Insert<ElectionUnitDTO>(request);
                }

                Hide();
            }
        }

    }
}
