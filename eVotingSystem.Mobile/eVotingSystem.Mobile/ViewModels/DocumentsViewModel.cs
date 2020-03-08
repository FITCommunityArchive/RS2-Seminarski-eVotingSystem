using eVotingSystem.CORE.Requests;
using eVotingSystem.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eVotingSystem.Mobile.ViewModels
{
    public class DocumentsViewModel:BaseViewModel
    {
        public ObservableCollection<Document> Items { get; set; } = new ObservableCollection<Document>();
        APIService _FileService { get; set; } = new APIService("File");
        APIService _UserService { get; set; } = new APIService("User");
        public Stream InputFileStream { get; set; }
                                           //public string Header { get; set; }


        //public Command BoxCommand
        //{
        //    get
        //    {

        //        return new Command(async () => await ExecuteLoadItemsCommand());
        //    }
        //}



        //UserDTO _SelectedUser = null;

        //public UserDTO SelectedUser
        //{
        //    get { return _SelectedUser; }
        //    set
        //    {
        //        SetProperty(ref _SelectedUser, value);
        //    }
        //}
        //public ObservableCollection<UserDTO> Users { get; set; } = new ObservableCollection<UserDTO>();

        public async Task Init()
        {
            

        }
        public DocumentsViewModel()
        {

            Init();
        }

        //public ICommand OpenWebCommand { get; }
        public List<FileDTO> Documents { get; private set; }


        private async Task loadValues()
        {
            Documents = await _FileService.Get<List<FileDTO>>(null);

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
            await loadValues();
            IsBusy = true;
            try
            {

                foreach (var item in Documents.Where(s=> s.Path.Substring(s.Path.Length - 3).ToLower()== "doc" || s.Path.Substring(s.Path.Length - 3).ToLower() == "pdf"))
                {
                   Items.Add(new Document() {Name=item.Name, Path=item.Path});
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
