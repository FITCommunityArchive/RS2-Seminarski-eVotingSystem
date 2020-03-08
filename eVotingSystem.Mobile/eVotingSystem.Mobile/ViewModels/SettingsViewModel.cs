using eVotingSystem.CORE.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eVotingSystem.Mobile.ViewModels
{
    public class SettingsViewModel: BaseViewModel
    {
        APIService _UserService { get; set; } = new APIService("User");
        APIService _ElectionUnitService { get; set; } = new APIService("ElectionUnit");

        public SettingsViewModel()
        {

        }
        string _username = APIService.CurrentUser.UserName;
        string _error = string.Empty;
        public string Username 
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
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
        string _passwordConfirmation = string.Empty;
        public string PasswordConfirmation
        {
            get { return _passwordConfirmation; }
            set { SetProperty(ref _passwordConfirmation, value); }
        }
        string _Loading = string.Empty;
        public string Loading
        {
            get { return _Loading; }
            set { SetProperty(ref _Loading, value); }
        }
        public Command LoadItemsCommand
        {
            get
            {
                return new Command(async () => await ExecuteLoadItemsCommand());
            }
        }
        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
            {
                return;
            }
            var list = await _ElectionUnitService.Get<List<ElectionUnitDTO>>(null);
            foreach (var item in list)
            {
                Units.Add(item);
            }
            SelectedUnit = Units.Where(q => q.Id == APIService.CurrentUser.ElectionUnitId).FirstOrDefault();
        }
        public Command SaveCommand
        {
            get
            {
                return new Command(async () => await SaveUser());
            }
        }
        public async Task SaveUser()
        {
            if (IsBusy)
            {
                return;
            }

            if (SelectedUnit == null || Username == "" || Password=="" || Password==string.Empty || PasswordConfirmation==string.Empty ||Password!=PasswordConfirmation)
            {
                InvalidInput = true;
                Loading = "";
                return;
            }
            else
            {
                Loading = "Loading...";

            }
            InvalidInput = false;
            IsBusy = true;
            var request = new UserRequest() { Id = APIService.CurrentUser.Id, UserName = Username, FirstName=APIService.CurrentUser.FirstName, LastName= APIService.CurrentUser.LastName, Password = Password, PasswordConfirmed = PasswordConfirmation, ElectionUnitId = SelectedUnit.Id, CardId = APIService.CurrentUser.CardId, CityId = APIService.CurrentUser.CityId, FileId = APIService.CurrentUser.FileId, JMBG = APIService.CurrentUser.JMBG, Mail = APIService.CurrentUser.Mail, UserTypes = APIService.CurrentUser.UserTypes };
            try
            {

            await _UserService.Update<UserDTO>(APIService.CurrentUser.Id, request);
                InvalidInput = false;

            }
            catch (Exception ex)
            {
                InvalidInput = true;
            }
            finally
            { 
                IsBusy = false;
                Loading = "Finished";

            }

        }

        ElectionUnitDTO _SelectedUnit = null;

        public ElectionUnitDTO SelectedUnit
        {
            get { return _SelectedUnit; }
            set
            {
                SetProperty(ref _SelectedUnit, value);
            }
        }
        public ObservableCollection<ElectionUnitDTO> Units { get; set; } = new ObservableCollection<ElectionUnitDTO>();
        public bool _InvalidInput =false;
        public bool InvalidInput
        {
            get { return _InvalidInput; }
            set { SetProperty(ref _InvalidInput, value); }
        }
    }
}
