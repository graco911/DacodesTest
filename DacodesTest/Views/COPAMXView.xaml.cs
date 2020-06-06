using DacodesTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class COPAMXView : ContentPage
    {
        public static COPAMXViewViewModel COPAMXViewViewModel { get; set; }

        public COPAMXView()
        {
            InitializeComponent();
            BindingContext = COPAMXViewViewModel = new COPAMXViewViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}