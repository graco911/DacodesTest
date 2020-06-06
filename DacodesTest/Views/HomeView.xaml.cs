using DacodesTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : TabbedPage
    {
        public static HomeViewViewModel HomeViewViewModel { get; set; }

        public HomeView()
        {
            InitializeComponent();
            BindingContext = HomeViewViewModel = new HomeViewViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            HomeViewViewModel.GetGames.Execute(null);
        }
    }
}