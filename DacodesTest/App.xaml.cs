using DacodesTest.Services;
using DacodesTest.Views;
using Xamarin.Forms;

namespace DacodesTest
{
    public partial class App : Application
    {
        public static ApiService apiService { get; set; }
        public App()
        {
            InitializeComponent();
            try
            {
                MainPage = new MainPageView();
                apiService = new ApiService();
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
