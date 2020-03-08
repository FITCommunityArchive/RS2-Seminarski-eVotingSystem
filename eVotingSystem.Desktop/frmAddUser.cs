using eVotingSystem.CORE.Constants;
using eVotingSystem.CORE.Requests;
using eVotingSystem.Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVotingSystem.Desktop
{
    public partial class frmAddUser : Form
    {
        APIService _UserAPIService = new APIService("User");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddUser(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAddUser_Load(object sender, EventArgs e)
        {
            if (cmbCityId.Items.Count == 0)
            {
                cmbCityId = await cmbHelper.GetCities(cmbCityId);
            }
            if (_id.HasValue)
            {
                var model = await _UserAPIService.GetById<UserDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpUser);
                cmbCityId.SelectedValue = model.CityId;
            }
            if (cmbElectionUnitId.Items.Count == 0)
            {
                cmbElectionUnitId = await cmbHelper.GetElectionUnits(cmbElectionUnitId);
            }
            if (_id.HasValue)
            {
                var model = await _UserAPIService.GetById<UserDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpUser);
                cmbElectionUnitId.SelectedValue = model.ElectionUnitId;
            }
            if (cmbUserType.Items.Count == 0)
            {
                cmbUserType = await cmbHelper.GetUserTypes(cmbUserType);
            }
            if (_id.HasValue)
            {
                var model = await _UserAPIService.GetById<UserDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpUser);
                cmbUserType.SelectedValue = model.UserTypes;
            }
        }
        private async void btnSaveUser(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                bool valid = true;
                if (cmbUserType.SelectedItem ==null)
                {
                    lblErrorUserType.Visible = true;
                    valid = false;
                }
                else
                    lblErrorUserType.Visible = false;
                var request = ControlsHelper.MapControlsToProps(new UserRequest(), grpUser);
                if (request.FirstName==null || request.FirstName.Length <3)
                {
                    lblErrorFirstName.Visible = true;
                    valid = false;
                }
                else
                    lblErrorFirstName.Visible = false;
                if (request.LastName.Length <3)
                {
                    lblErrorLastName.Visible = true;
                    valid = false;
                }
                else
                    lblErrorLastName.Visible = false;
                if (request.CardId.Length<9)
                {
                    lblErrorCardID.Visible = true;
                    valid = false;
                }
                else
                    lblErrorCardID.Visible = false;
                if (request.JMBG.Length <11)
                {
                    lblErrorJMBG.Visible = true;
                    valid = false;
                }
                else
                    lblErrorJMBG.Visible = false;
                if (request.CityId == 0)
                {
                    lblErrorCity.Visible = true;
                    valid = false;
                }
                else
                    lblErrorCity.Visible = false;
                if (!valid)
                {
                    return;
                }
                request.UserName = request.CardId;
                request.Password = "test";
                request.PasswordConfirmed = "test";
                ComboBoxItem selected = (ComboBoxItem)cmbUserType.SelectedItem;
                request.UserTypes = (UserTypes)selected.Value;

                if (request.FileId == 0) request.FileId = null;
                if (request.ElectionUnitId == 0) request.ElectionUnitId = null;
                    if (_id.HasValue)
                {
                    await _UserAPIService.Update<UserDTO>(_id.Value, request);
                }
                else
                {
                    await _UserAPIService.Insert<UserDTO>(request);
                }

                Hide();
            }
        }

        private void btnOpenVoterForm(object sender, EventArgs e)
        {
            var request = ControlsHelper.MapControlsToProps(new UserRequest(), grpUser);

            frmAddVoter frm = new frmAddVoter(request.Id);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            var fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                APIService _FileSystemUploadAPIService = new APIService("FileSystemUpload");
                FileDTO file = await _FileSystemUploadAPIService.UploadFile<FileDTO>(openFileDialog1.FileName, openFileDialog1.SafeFileName, File.ReadAllBytes(openFileDialog1.FileName));

                FileRequest fileRequest = new FileRequest();
                var fileName = openFileDialog1.FileName;
                fileRequest.Name = file.Name;
                fileRequest.Path = file.Path;


                APIService _FileAPIService = new APIService("File");
                var uploadedFile = await _FileAPIService.Insert<FileDTO>(fileRequest);

                cmbFileId.Items.Add(new ComboBoxItem() { Value = uploadedFile.Id, Text = "" });
                cmbFileId.SelectedIndex = 0;

                //request.PictureId = uploadedFile.Id;
                //request.PictureId = uploadedFile.Id;
                Image image = Image.FromFile(fileName);
                upldPicture.Image = image;
                upldPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
