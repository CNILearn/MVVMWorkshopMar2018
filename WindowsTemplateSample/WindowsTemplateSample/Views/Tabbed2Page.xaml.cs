using System;

using Windows.UI.Xaml.Controls;

using WindowsTemplateSample.ViewModels;

namespace WindowsTemplateSample.Views
{
    public sealed partial class Tabbed2Page : Page
    {
        public Tabbed2ViewModel ViewModel { get; } = new Tabbed2ViewModel();

        public Tabbed2Page()
        {
            InitializeComponent();
        }
    }
}
