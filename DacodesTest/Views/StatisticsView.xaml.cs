using DacodesTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StatisticsView : ContentPage
    {
        public StatisticsViewViewModel StatisticsViewViewModel { get; }

        public StatisticsView()
        {
            InitializeComponent();
            BindingContext = StatisticsViewViewModel = new StatisticsViewViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}