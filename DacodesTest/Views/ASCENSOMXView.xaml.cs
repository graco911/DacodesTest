using DacodesTest.Interfaces;
using DacodesTest.Models.Games;
using DacodesTest.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ASCENSOMXView : ContentPage
    {
        public static IReminderService Reminder { get; set; }
        public static ASCENSOMXViewViewModel ASCENSOMXViewViewModel { get; set; }

        public ASCENSOMXView()
        {
            InitializeComponent();
            BindingContext = ASCENSOMXViewViewModel = new ASCENSOMXViewViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var game = (GameData)e.Item;

            var answer = await DisplayAlert("Información", "¿Desea agendar el evento en el calendario?", "Aceptar", "Cancelar");

            if (answer)
            {
                try
                {
                    DependencyService.Get<IReminderService>().AddEvent(
                        game.Datetime,
                        game.Datetime,
                        game.Local ? string.Format("{0} vs {1}", "Venados F.C.", game.Opponent) : string.Format("{0} vs {1}", game.Opponent, "Venados F.C."),
                        game.Image,
                        string.Empty, async (success) =>
                        {
                            if (success)
                            {
                                await DisplayAlert("Información", "El evento ha sido agendado", "Aceptar");
                            }
                        }, Guid.NewGuid().ToString());
                }
                catch (Exception ex)
                {
                    await DisplayAlert("Información", "El evento no ha sido agendado", "Aceptar");
                }
            }
        }
    }
}