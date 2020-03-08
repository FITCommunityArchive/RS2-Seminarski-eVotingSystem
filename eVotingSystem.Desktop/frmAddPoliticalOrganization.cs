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
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;

namespace eVotingSystem.Desktop
{
    public partial class frmAddPoliticalOrganization : Form
    {
        APIService _PoliticalOrganizationAPIService = new APIService("PoliticalOrganization");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        PoliticalOrganizationRequest request = new PoliticalOrganizationRequest();

        public frmAddPoliticalOrganization(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }

        private async void frmAddPoliticalOrganization_Load(object sender, EventArgs e)
        {
            if (cmbCityId.Items.Count == 0)
            {
                cmbCityId = await cmbHelper.GetCities(cmbCityId);
            }
            if (_id.HasValue)
            {
                var model = await _PoliticalOrganizationAPIService.GetById<PoliticalOrganizationDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpPoliticalOrganization);
                cmbCityId.SelectedValue = model.CityId;
            }
            if (cmbPoliticalOrientation.Items.Count == 0)
            {
                cmbPoliticalOrientation = await cmbHelper.GetPoliticalOrientations(cmbPoliticalOrientation);
            }
            if (_id.HasValue)
            {
                var model = await _PoliticalOrganizationAPIService.GetById<PoliticalOrganizationDTO>(_id.Value);
                ControlsHelper.MapPropsToControls(model, grpPoliticalOrganization);
                cmbPoliticalOrientation.SelectedValue = model.PoliticalOrientation;
            }
        }

        private async void btnSavePoliticalOrganization(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request2 = ControlsHelper.MapControlsToProps(request, grpPoliticalOrganization);
                if (request.CityId == 0)
                {
                    lblError.Visible = true;
                    return;
                }
                else
                    lblError.Visible = false;
                if (request.PictureId == 0) request.PictureId = null;
                if (request.FileId == 0) request.FileId = null;
                    if (_id.HasValue)
                {
                    await _PoliticalOrganizationAPIService.Update<PoliticalOrganizationDTO>(_id.Value, request2);
                }
                else
                {
                    await _PoliticalOrganizationAPIService.Insert<PoliticalOrganizationDTO>(request2);
                }

                Hide();
            }
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
                var uploadedFile=await _FileAPIService.Insert<FileDTO>(fileRequest);

                cmbPictureId.Items.Add(new ComboBoxItem() { Value = uploadedFile.Id, Text = "" });
                cmbPictureId.SelectedIndex = 0;

                request.PictureId = uploadedFile.Id;
                //request.PictureId = uploadedFile.Id;
                Image image = Image.FromFile(fileName);
                upldPicture.Image = image;
                upldPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void btnAddDocument_Click(object sender, EventArgs e)
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
                request.FileId = uploadedFile.Id;

                cmbFileId.Items.Add(new ComboBoxItem() { Value = uploadedFile.Id, Text = "" });
                cmbFileId.SelectedIndex=0;
                txtDocumentName.Text = openFileDialog2.SafeFileName;
                //request.FileId = uploadedFile.Id;
            }
        }
    }
}
