using Windows.UI.Xaml.Controls;

using AppUno.Model;

namespace AppUno
{
    public sealed partial class MainPage : Page
    {
        public ViewModel ViewModel { get; }

        public MainPage()
        {
            this.InitializeComponent();
            ViewModel = new ViewModel();
        }
    }
}
