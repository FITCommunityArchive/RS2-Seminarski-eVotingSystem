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
    public partial class frmCreateElectionCycle : Form
    {
        APIService _electionCycleAPIService = new APIService("ElectionCycle");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmCreateElectionCycle(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmCreateElectionCycle_Load(object sender, EventArgs e)
        {
            //if (cmbCountryId.Items.Count == 0)
            //{
            //    cmbCountryId = await cmbHelper.GetCountries(cmbCountryId);
            //}
            //if (_id.HasValue)
            //{
            //    var model = await _cityAPIService.GetById<CityDTO>(_id.Value);
            //    ControlsHelper.MapPropsToControls(model, grpCity);
            //    cmbCountryId.SelectedValue = model.CountryId;
            //}
            APIService _ElectiveListAPIService = new APIService("ElectiveList");
            chklstElectiveLists.DataSource = await _ElectiveListAPIService.Get<List<ElectiveListDTO>>(null);

            chklstElectiveLists.DisplayMember = "ElectionPositionName";
            chklstElectiveLists.ClearSelected();
        }

        private async void btnSaveElectionCycle(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                

                var request = ControlsHelper.MapControlsToProps(new ElectionCycleRequest(), grpElectionCycle);
                if (selectedItems.Count == 0)
                {
                    lblError.Visible = true;
                    return;
                }
                else
                    lblError.Visible = false;
                ElectionCycleDTO response = new ElectionCycleDTO();
                if (_id.HasValue)
                {
                    response= await _electionCycleAPIService.Update<ElectionCycleDTO>(_id.Value, request);
                }
                else
                {
                    response= await _electionCycleAPIService.Insert<ElectionCycleDTO>(request);
                }
                //foreach (Control item in grpElectionCycle.Controls)
                //{
                //    if (item.Name== "chklstElectiveLists")
                //    {
                //        CheckedListBox a = (CheckedListBox)item;
                //        foreach (CheckBox item2 in a.Items)
                //        {
                //            if (item2.Checked)
                //            {
                //                var b = 0;
                //            }
                //        }
                //    }
                //}
                foreach (ElectiveListDTO item in selectedItems)
                {
                    APIService _ElectionCycleElectiveListAPIService = new APIService("ElectionCycleElectiveList");
                    if (item!=null)
                    {
                    ElectionCycleElectiveListRequest r = new ElectionCycleElectiveListRequest() { ElectiveListId = item.Id, ElectionCycleId = response.Id };
                    await _ElectionCycleElectiveListAPIService.Insert<ElectionCycleElectiveListDTO>(r);
                    }
                }

                Hide();
            }
        }
        List<object> selectedItems=new List<object>();
        private void SelectItem(object sender, EventArgs e)
        {
            
        }

        private void chklstElectiveLists_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (selectedItems.Contains(chklstElectiveLists.Items[e.Index]))
                selectedItems.Remove(chklstElectiveLists.Items[e.Index]);
            else
                selectedItems.Add(chklstElectiveLists.Items[e.Index]);
        }
    }
}
