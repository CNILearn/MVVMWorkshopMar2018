using System;

using Windows.UI.Xaml.Controls;

using WindowsTemplateSample.ViewModels;

namespace WindowsTemplateSample.Views
{
    public sealed partial class WebView1Page : Page
    {
        public WebView1ViewModel ViewModel { get; } = new WebView1ViewModel();

        public WebView1Page()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
