using eVotingSystem.CORE.Requests;
using eVotingSystem.Desktop.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVotingSystem.Desktop
{
    public partial class Login : Form
    {
        private int? _id;
        APIService _UserAPIService = new APIService("User");
        public Login(int? id=null)
        {
            InitializeComponent();
            _id = id;
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblLoading.Visible = true;
            lblError.Visible = false;

            List<UserDTO> users= new List<UserDTO>();
            try
            {
                users= await _UserAPIService.Get<List<UserDTO>>(new UserAuthDTO() { Username=txtUserName.Text});
                if (users.First() != null)
                {

                    if (users.First().PasswordHash == GetHashedPassword(txtPassword.Text, users.First().PasswordSalt))
                    {
                        APIService.CurrentUser = users.First();
                        if (APIService.CurrentUser.UserTypes != CORE.Constants.UserTypes.Administrator)
                        {
                            APIService _VoterAPIService = new APIService("Voter");
                            List<VoterDTO> voter = await _VoterAPIService.Get<List<VoterDTO>>(new VoterSearchRequest() { UserId = APIService.CurrentUser.Id });
                            if (voter.Count==0 || voter[0].IsVoted==true)
                            {
                                lblErrorInvalidVoter.Visible = true;
                                lblLoading.Visible = false;
                                return;
                            }
                            else
                            {
                                lblErrorInvalidVoter.Visible = false;
                            }
                            APIService.Token = Guid.NewGuid();
                            IndexVoter frm = new IndexVoter();
                            //frm.StartPosition = FormStartPosition.CenterScreen;
                            frm.Show();
                        }
                        else
                        {
                            frmIndex frm = new frmIndex();
                            //frm.StartPosition = FormStartPosition.CenterScreen;
                            frm.Show();
                        }
                    Hide();
                    }
                    lblError.Visible = true;
                }
            }
            catch
            {
                lblError.Visible = true;
            }
            lblLoading.Visible = false;

        }
        public static string GetHashedPassword(string password, string salt)
    {
        byte[] src = Convert.FromBase64String(salt);
        byte[] bytes = Encoding.Unicode.GetBytes(password);
        byte[] dst = new byte[src.Length + bytes.Length];

        System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
        System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

        HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
        byte[] inArray = algorithm.ComputeHash(dst);
        return Convert.ToBase64String(inArray);
    }

    public static string GenerateSalt()
    {
        var buf = new byte[16];
        (new RNGCryptoServiceProvider()).GetBytes(buf);
        return Convert.ToBase64String(buf);
    }
}
}
