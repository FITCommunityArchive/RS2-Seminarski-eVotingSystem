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
    public partial class ViewPdf : ContentPage
    {
        PdfViewerViewModel viewModel;
        public ViewPdf(PdfViewerViewModel vm)
        {
            InitializeComponent();
            BindingContext = this.viewModel = vm;

        }
    }
}