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
    public partial class frmSendMessage : Form
    {
        APIService _messageAPIService = new APIService("Message");
        APIService _UserAPIService = new APIService("User");
        private int? _id;
        ComboBoxHelper cmbHelper = new ComboBoxHelper();
        public frmSendMessage(int? id = null)
        {
            InitializeComponent();
            _id = id;
        }
        private class MessageView
        {
            public string Username { get; set; }
            public string Content { get; set; }
            public string Title { get; set; }
            public DateTime Time{ get; set; }
        }
        private async void frmSendMessage_Load(object sender, EventArgs e)
        {
            //if (cmbCountryId.Items.Count == 0)
            //{
            cmbRecieverId = await cmbHelper.GetUsers(cmbRecieverId);
            var messages = await _messageAPIService.Get<List<MessageDTO>>(new MessageSearchRequest() { RecieverId = APIService.CurrentUser.Id });
            List<MessageView> messagesItems = new List<MessageView>();
            foreach (var item in messages.OrderBy(y=>y.TimeOfSending))
            {
                var user = await _UserAPIService.Get<List<UserDTO>>(new UserSearchRequest() { Id = (int)item.SenderId });
                if (user.Count != 0)
                    messagesItems.Add(new MessageView() { Username = user[0].FirstName + " " + user[0].LastName, Title=item.Header, Content = item.Content, Time = item.TimeOfSending });
            }
            lstMessages.DataSource = messagesItems;
            //}
            //if (_id.HasValue)
            //{
            //    var model = await _cityAPIService.GetById<CityDTO>(_id.Value);
            //    ControlsHelper.MapPropsToControls(model, grpCity);
            //    cmbCountryId.SelectedValue = model.CountryId;
            //}
        }

        private async void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var request = ControlsHelper.MapControlsToProps(new MessageRequest(), grpMessage);
                if (cmbRecieverId.SelectedItem==null)
                {
                    lblError.Visible = true;
                    return;
                }
                if (request.PictureId==0)
                {
                    request.PictureId = null;
                }
                if (request.SenderId==0)
                {
                    request.SenderId = APIService.CurrentUser.Id;
                }
                request.TimeOfSending = DateTime.Now;
                lblError.Visible = false;
                List<UserDTO> admin = await _UserAPIService.Get<List<UserDTO>>(null);
                if (_id.HasValue)
                {
                    await _messageAPIService.Update<MessageDTO>(_id.Value, request);
                }
                else
                {
                    await _messageAPIService.Insert<MessageDTO>(request);
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
                var uploadedFile = await _FileAPIService.Insert<FileDTO>(fileRequest);

                cmbPictureId.Items.Add(new ComboBoxItem() { Value = uploadedFile.Id, Text = "" });
                cmbPictureId.SelectedIndex = 0;

                //request.PictureId = uploadedFile.Id;
                Image image = Image.FromFile(fileName);
                //upldPicture.Image = image;
                //upldPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            }
    }
}
