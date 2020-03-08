
using eVotingSystem.Mobile.Views;
using eVotingSystem.CORE.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace eVotingSystem.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; set; }

        private const string HashName = "SHA1";
        APIService _UserAPIService = new APIService("User");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        string _error = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _loading = string.Empty;
        public string Loading
        {
            get { return _loading; }
            set { SetProperty(ref _loading, value); }
        }
        public string Error
        {
            get { return _error; }
            set { SetProperty(ref _error, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        async Task Login()
        {
            Loading = "loading...";
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;
            List<UserDTO> users = new List<UserDTO>();
            try
            {
                users = await _UserAPIService.Get<List<UserDTO>>(new UserAuthDTO() { Username = Username });
                if (users.First() != null)
                {
                    string hash = GetHashedPassword(Password, users.First().PasswordSalt);
                    if (users.First().PasswordHash == hash)
                    {
                        APIService.CurrentUser = users.First();
                        Loading = "";
                    }
                    else
                    {
                        Loading = "";

                        Error = "Wrong username or password";
                        return;
                    }
                }
                else
                {
                    Loading = "";

                    Error = "Wrong username or password";
                    return;
                }
            }
            catch (System.Exception e)
            {
                Loading = "";

                Error = "Wrong username or password";
                return;
            }

            try
            {
                    Application.Current.MainPage = new MainPage();
            }
            catch (System.Exception e)
            {
                    await Application.Current.MainPage.DisplayAlert("Error", "You are not authenticated ", "OK");
            }

        }
        public static string GetHashedPassword(string password, string salt)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            SHA1 algorithm = SHA1.Create();
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
