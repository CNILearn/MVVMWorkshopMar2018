using System;

using Windows.UI.Xaml.Controls;

using WindowsTemplateSample.ViewModels;

namespace WindowsTemplateSample.Views
{
    public sealed partial class Grid1Page : Page
    {
        public Grid1ViewModel ViewModel { get; } = new Grid1ViewModel();

        // TODO WTS: Change the grid as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public Grid1Page()
        {
            InitializeComponent();
        }
    }
}
