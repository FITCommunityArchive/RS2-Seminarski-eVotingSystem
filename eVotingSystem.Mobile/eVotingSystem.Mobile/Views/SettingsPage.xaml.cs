using eVotingSystem.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eVotingSystem.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        SettingsViewModel viewModel; 
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new SettingsViewModel();

        }
    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (viewModel.Units.Count == 0)
            viewModel.LoadItemsCommand.Execute(null);
    }
    }
}