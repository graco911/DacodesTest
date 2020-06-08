using DacodesTest.Models.Players;
using DacodesTest.ViewModels;
using Rg.Plugins.Popup.Services;
using System.Linq;
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

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new PlayerDetailView((DataPlayer)e.CurrentSelection.First()), true);
        }
    }
}