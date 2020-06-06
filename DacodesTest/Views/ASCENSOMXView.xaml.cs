using DacodesTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ASCENSOMXView : ContentPage
    {
        public static ASCENSOMXViewViewModel ASCENSOMXViewViewModel { get; set; }

        public ASCENSOMXView()
        {
            InitializeComponent();
            BindingContext = ASCENSOMXViewViewModel = new ASCENSOMXViewViewModel();
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