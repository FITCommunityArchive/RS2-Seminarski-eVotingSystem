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
    public partial class frmAddCandidate : Form
    {
        APIService _CandidateAPIService = new APIService("Candidate");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmAddCandidate(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAddCandidate_Load(object sender, EventArgs e)
        {
            if (cmbPoliticalOrganizationId.Items.Count == 0)
            {
                cmbPoliticalOrganizationId = await cmbHelper.GetPoliticalOrganizations(cmbPoliticalOrganizationId);
            }
            if (_id.HasValue)
            {
                var model = await _CandidateAPIService.GetById<CandidateDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpCandidate);
                cmbPoliticalOrganizationId.SelectedValue = model.PoliticalOrganizationId;
            }
            if (cmbCityId.Items.Count == 0)
            {
                cmbCityId = await cmbHelper.GetCities(cmbCityId);
            }
            if (_id.HasValue)
            {
                var model = await _CandidateAPIService.GetById<CandidateDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpCandidate);
                cmbCityId.SelectedValue = model.CityId;
            }
            if (cmbGender.Items.Count == 0)
            {
                cmbGender = await cmbHelper.GetGenders(cmbGender);
            }

            if (cmbNationalityId.Items.Count == 0)
            {
                cmbNationalityId = await cmbHelper.GetNationalities(cmbNationalityId);
            }
            if (_id.HasValue)
            {
                var model = await _CandidateAPIService.GetById<CandidateDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpCandidate);
                cmbNationalityId.SelectedValue = model.NationalityId;
            }
        }

        private async void btnSaveCandidate(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new CandidateRequest(), grpCandidate);
                if (request.CityId==0 || request.NationalityId==0 || request.PoliticalOrganizationId==0 || request.ResumeId==0 || request.PictureId==0)
                {
                    lblError.Visible = true;
                    return;
                }
                else
                    lblError.Visible = false;
                if (_id.HasValue)
                {
                    await _CandidateAPIService.Update<CandidateDTO>(_id.Value, request);
                }
                else
                {
                    await _CandidateAPIService.Insert<CandidateDTO>(request);
                }

                //Hide();
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Document Files (PDF,DOC)|*.PDF;*.DOC";

            var fileResult = openFileDialog2.ShowDialog();
            if (fileResult == DialogResult.OK)
            {
                APIService _FileSystemUploadAPIService = new APIService("FileSystemUpload");
                FileDTO file = await _FileSystemUploadAPIService.UploadFile<FileDTO>(openFileDialog2.FileName, openFileDialog2.SafeFileName, File.ReadAllBytes(openFileDialog2.FileName));

                FileRequest fileRequest = new FileRequest();
                var fileName = openFileDialog2.FileName;
                fileRequest.Name = file.Name;
                fileRequest.Path = file.Path;


                APIService _FileAPIService = new APIService("File");
                var uploadedFile = await _FileAPIService.Insert<FileDTO>(fileRequest);
                //request.FileId = uploadedFile.Id;

                cmbResumeId.Items.Add(new ComboBoxItem() { Value = uploadedFile.Id, Text = "" });
                cmbResumeId.SelectedIndex = 0;
                txtFile.Text = openFileDialog2.SafeFileName;
                //request.FileId = uploadedFile.Id;
            }
        }

        private async void btnAddPicture_Click(object sender, EventArgs e)
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

                cmbPictureId.Items.Add(new ComboBoxItem() { Value = uploadedFile.Id, Text = "" });
                cmbPictureId.SelectedIndex = 0;

                //request.PictureId = uploadedFile.Id;
                //request.PictureId = uploadedFile.Id;
                Image image = Image.FromFile(fileName);
                upldPicture.Image = image;
                upldPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
