using System;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using WindowsTemplateSample.ViewModels;

namespace WindowsTemplateSample.Views
{
    public sealed partial class Settings1Page : Page
    {
        public Settings1ViewModel ViewModel { get; } = new Settings1ViewModel();

        //// TODO WTS: Change the URL for your privacy policy in the Resource File, currently set to https://YourPrivacyUrlGoesHere

        public Settings1Page()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.Initialize();
        }
    }
}
