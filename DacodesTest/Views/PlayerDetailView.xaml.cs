using DacodesTest.Models.Players;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms.Xaml;

namespace DacodesTest.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlayerDetailView : PopupPage
    {
        public PlayerDetailView(DataPlayer dataPlayer)
        {
            InitializeComponent();

            PlayerImage.Source = dataPlayer.Image;
            PlayerName.Text = string.Format("{0} {1} {2}", dataPlayer.Name, dataPlayer.FirstSurname, dataPlayer.SecondSurname);
            PlayerPosition.Text = dataPlayer.Position;

            PlayerBirthdate.Text = dataPlayer.Birthday.ToShortDateString();
            PlayerBirthplace.Text = dataPlayer.BirthPlace;
            PlayerWeight.Text = string.Format("{0} KG", dataPlayer.Weight);
            PlayerHeight.Text = string.Format("{0} M", dataPlayer.Height);
            PlayerLastTeam.Text = dataPlayer.LastTeam;
        }
    }
}