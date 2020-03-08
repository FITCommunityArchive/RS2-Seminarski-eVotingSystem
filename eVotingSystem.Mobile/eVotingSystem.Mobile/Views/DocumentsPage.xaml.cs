using eVotingSystem.Mobile.Models;
using eVotingSystem.Mobile.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace eVotingSystem.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DocumentsPage : ContentPage
    {
        DocumentsViewModel viewModel;
        APIService _fileSystemService = new APIService("FileSystemUpload");
        public object ApplicationData { get; private set; }

        public DocumentsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new DocumentsViewModel();

        }
        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Document;
            if (item == null)
                return;

            //var supportsUri = await Launcher.CanOpenAsync("lyft://");
            //if (supportsUri) .Remove(0, 20)
            string s = @"eVotingSystem.WebAPI\" + item.Path;
//            var backingFile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.
//GetExecutingAssembly().CodeBase); 
//            backingFile += s;
            var exePath = Path.GetDirectoryName(System.Reflection
                   .Assembly.GetExecutingAssembly().CodeBase);
            Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
            string appRoot = appPathMatcher.Match(exePath).Value;
            var k = System.IO.Directory.GetParent(Path.GetDirectoryName(appRoot));
            var p = Path.Combine(k.FullName, s);

            //if (supportsUri)
            //    await Launcher.OpenAsync(p);
            //await Launcher.OpenAsync(new OpenFileRequest
            //{
            //    File = new ReadOnlyFile(p)
            //});
            //Device.OpenUri(new Uri(p));

            var file = await _fileSystemService.GetFile(p);
            Stream stream = new MemoryStream(file);
            //Stream o;
            //using (FileStream fs = new FileStream(p,
            //            FileMode.Open, FileAccess.Read))
            //{
            //    viewModel.InputFileStream = fs;
            //    o = fs;
            //}
            await Navigation.PushAsync(new ViewPdf(new PdfViewerViewModel() { PdfDocumentStream = stream }));


            //PdfDocument pdfDocument = await PdfDocument.LoadFromFileAsync(file);
            //for (uint i = 0; i < pdfDocument.PageCount; i++)
            //{
            //    BitmapImage image = new BitmapImage();
            //    var page = pdfDocument.GetPage(i);
            //    using (InMemoryRandomAccessStream stream = new InMemoryRandomAccessStream())
            //    {
            //        await page.RenderToStreamAsync(stream);
            //        await image.SetSourceAsync(stream);
            //    }
            //}

            //var file = await ApplicationData.Current.LocalFolder.GetFileAsync("My.docx");

            //if (file != null)
            //{
            //    // Launch the retrieved file
            //    await Launcher.LaunchFileAsync(new OpenFileRequest
            //    {
            //        File = new ReadOnlyFile(p)
            //    });
            //}
            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Items.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
        public async Task OpenRideShareAsync()
        {
            var supportsUri = await Launcher.CanOpenAsync("lyft://");
            if (supportsUri)
                await Launcher.OpenAsync("lyft://ridetype?id=lyft_line");
        }
    }
}