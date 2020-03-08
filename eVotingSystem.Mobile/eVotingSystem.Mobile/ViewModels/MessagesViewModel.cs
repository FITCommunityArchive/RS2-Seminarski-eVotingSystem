using eVotingSystem.CORE.Constants;
using eVotingSystem.CORE.Requests;
using eVotingSystem.Mobile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

namespace eVotingSystem.Mobile.ViewModels
{
    public class MessagesViewModel : BaseViewModel
    {
        public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
        APIService _MessageService { get; set; } = new APIService("Message");
        APIService _UserService { get; set; } = new APIService("User");
        //public string Header { get; set; }
        string _Header;
        public string Header
        {
            get { return _Header; }
            set
            {
                SetProperty(ref _Header, value);
            }
        }
        //public string Content { get; set; }
        string _Content;
        public string Content
        {
            get { return _Content; }
            set
            {
                SetProperty(ref _Content, value);
            }
        }
        bool _IsInbox = false;
        public bool IsInbox
        {
            get { return _IsInbox; }
            set
            {
                //if (IsBusy)
                //{
                //    return;
                //}
                SetProperty(ref _IsInbox, value);
                //if (value != null)
                //{
                //    if (Items.Count > 0)
                //    {
                //        Items.Clear();
                //    }
                //    LoadItemsCommand.Execute(_SelectedUser);
                //}

            }
        }
        string _lblBoxText = "Inbox";
        public string lblBoxText
        {
            get { return _lblBoxText; }
            set
            {
                SetProperty(ref _lblBoxText, value);
            }
        }
        string _btnBoxText = "Outbox";
        public string btnBoxText
        {
            get { return _btnBoxText; }
            set
            {
                SetProperty(ref _btnBoxText, value);
            }
        }
        public Command SendMessageCommand
        {
            get
            {
                return new Command(async () => await SendMessage());
            }
        }
        public Command BoxCommand
        {
            get
            {
                
                return new Command(async () => await ExecuteLoadItemsCommand());
            }
        }
        bool _InvalidInput = false;

        public bool InvalidInput
        {
            get { return _InvalidInput; }
            set
            {
                //if (IsBusy)
                //{
                //    return;
                //}
                SetProperty(ref _InvalidInput, value);
                //if (value != null)
                //{
                //    if (Items.Count > 0)
                //    {
                //        Items.Clear();
                //    }
                //    LoadItemsCommand.Execute(_SelectedUser);
                //}

            }
        }
        public async Task SendMessage()
        {
            if (IsBusy)
            {
                return;
            }
            if (_SelectedUser==null || Content==null)
            {
                InvalidInput = true;
                return;
            }
            InvalidInput = false;
            IsBusy = true;
            await _MessageService.Insert<MessageDTO>(new MessageRequest() { SenderId = APIService.CurrentUser.Id, Header = Header, Content = Content, PictureId = null, RecieverId = (int)_SelectedUser.Id, TimeOfSending = DateTime.Now });
            IsBusy = false;
            Header = "";
            Content = "";
            Users.Clear();
            Init();
        }

        UserDTO _SelectedUser = null;

        public UserDTO SelectedUser
        {
            get { return _SelectedUser; }
            set
            {
                //if (IsBusy)
                //{
                //    return;
                //}
                SetProperty(ref _SelectedUser, value);
                //if (value != null)
                //{
                //    if (Items.Count > 0)
                //    {
                //        Items.Clear();
                //    }
                //    LoadItemsCommand.Execute(_SelectedUser);
                //}

            }
        }
        public ObservableCollection<UserDTO> Users { get; set; } = new ObservableCollection<UserDTO>();

        public async Task Init()
        {
            List<UserDTO> list = new List<UserDTO>();
            switch (APIService.CurrentUser.UserTypes)
            {
                case UserTypes.Person:
                     list = await _UserService.Get<List<UserDTO>>(new UserSearchRequest()
                    {
                        UserTypes = UserTypes.Supervisor, ElectionUnitId=APIService.CurrentUser.ElectionUnitId
                    });
                    break;
                case UserTypes.Administrator:
                     list = await _UserService.Get<List<UserDTO>>(new UserSearchRequest()
                    {
                        UserTypes = UserTypes.Supervisor,
                        ElectionUnitId = APIService.CurrentUser.ElectionUnitId
                    });
                    break;
                case UserTypes.Supervisor:
                     list = await _UserService.Get<List<UserDTO>>(new UserSearchRequest() { ElectionUnitId = APIService.CurrentUser.ElectionUnitId });
                    break;
                default:
                    break;
            }
            
            foreach (var item in list)
            {
                Users.Add(item);
            }
        }
        public MessagesViewModel()
        {
            Title = "About";

            Init();
        }

        public ICommand OpenWebCommand { get; }
        public List<MessageDTO> Messages { get; private set; }
        public List<MessageDTO> MessagesOut { get; private set; }
        public ICommand LoadItemsCommand
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
            //orders.Add(await _ordersService.GetById<CountryDTO>(2));
            IsBusy = true;
            IsInbox = !IsInbox;
            if (IsInbox)
            {
                lblBoxText = "Inbox";
                btnBoxText = "Outbox";
            }
            else
            {
                btnBoxText = "Inbox";
                lblBoxText = "Outbox";
            }
            await loadValues();

            try
            {
                Items.Clear();
                if (IsInbox)
                {

                    foreach (var item in Messages.OrderBy(s => s.TimeOfSending))
                    {
                        var user = await _UserService.Get<List<UserDTO>>(new UserSearchRequest() { Id = (int)item.SenderId });
                        Items.Add(new Item() { Text = "From:" + user[0].FirstName + " " + user[0].LastName + "-" + item.Header, Description = item.Content });
                    }
                }
                else
                {

                    foreach (var item in MessagesOut.OrderBy(s => s.TimeOfSending))
                    {
                        var user2 = await _UserService.Get<List<UserDTO>>(new UserSearchRequest() { Id = (int)item.RecieverId });
                        Items.Add(new Item() { Text = "To:" + user2[0].FirstName + " " + user2[0].LastName + "-" + item.Header, Description = item.Content });
                    }
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

        private async Task loadValues()
        {
            Messages = await _MessageService.Get<List<MessageDTO>>(new MessageSearchRequest() { RecieverId=APIService.CurrentUser.Id});
            MessagesOut = await _MessageService.Get<List<MessageDTO>>(new MessageSearchRequest() { SenderId=APIService.CurrentUser.Id});
        }
    }
}