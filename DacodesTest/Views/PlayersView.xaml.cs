using DacodesTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayersView : ContentPage
    {
        public PlayersViewViewModel PlayersViewViewModel { get; }

        public PlayersView()
        {
            InitializeComponent();
            BindingContext = PlayersViewViewModel = new PlayersViewViewModel();
        }

    }
}