using System;

using Windows.UI.Xaml.Controls;

using WindowsTemplateSample.ViewModels;

namespace WindowsTemplateSample.Views
{
    public sealed partial class Tabbed1Page : Page
    {
        public Tabbed1ViewModel ViewModel { get; } = new Tabbed1ViewModel();

        public Tabbed1Page()
        {
            InitializeComponent();
        }
    }
}
