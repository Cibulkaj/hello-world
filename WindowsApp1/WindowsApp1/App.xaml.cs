using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml.Data;

namespace WindowsApp1
{
    /// Documentation on APIs used in this page:
    /// https://github.com/Windows-XAML/Template10/wiki

    [Bindable]
    sealed partial class App : Template10.Common.BootStrapper
    {
        public App() {
        //    Microsoft.ApplicationInsights.WindowsAppInitializer.InitializeAsync(
// Microsoft.ApplicationInsights.WindowsCollectors.Metadata |
// Microsoft.ApplicationInsights.WindowsCollectors.Session);
            InitializeComponent(); }

        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            await Task.CompletedTask;
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            NavigationService.Navigate(typeof(Views.MainPage));
            await Task.CompletedTask;
        }
    }
}

