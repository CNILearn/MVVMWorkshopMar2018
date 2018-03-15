using Windows.UI.Xaml.Controls;

using WindowsTemplateSample.ViewModels;

namespace WindowsTemplateSample.Views
{
    public sealed partial class Camera1Page : Page
    {
        public Camera1ViewModel ViewModel { get; } = new Camera1ViewModel();

        public Camera1Page()
        {
            InitializeComponent();
        }
    }
}
