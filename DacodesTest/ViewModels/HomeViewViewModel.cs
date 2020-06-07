using DacodesTest.Models.Games;
using DacodesTest.Views;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Refit;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace DacodesTest.ViewModels
{
    public class HomeViewViewModel : BaseViewModel
    {
        #region [ Constantes ]
        public Command GetGames { get; set; }
        #endregion

        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        #region [ Games ]
        private List<GameData> _games;

        public List<GameData> Games
        {
            get { return _games; }
            set { _games = value; }
        }
        #endregion

        #endregion

        #region [ Constructor ]
        public HomeViewViewModel()
        {
            GetGames = new Command(async () => await LoadGames());
        }
        #endregion

        #region [ Metodos/Comandos ]
        #region [ LoadGamesMethod ]
        private async Task LoadGames()
        {
            try
            {
                ASCENSOMXView.ASCENSOMXViewViewModel.IsBusy = true;
                COPAMXView.COPAMXViewViewModel.IsBusy = true;

                var requestData = await App.apiService.VenadosAPI.GamesGet();

                if (requestData.Success)
                {
                    Games = new List<GameData>(requestData.Result.Games);

                    ASCENSOMXView.ASCENSOMXViewViewModel.CreateGroup(Games.Where(a => a.League.Equals("Ascenso MX")).ToList());
                    COPAMXView.COPAMXViewViewModel.CreateGroup(Games.Where(a => a.League.Equals("Copa MX")).ToList());

                    ASCENSOMXView.ASCENSOMXViewViewModel.IsBusy = false;
                    COPAMXView.COPAMXViewViewModel.IsBusy = false;
                }
                else
                {
                    ASCENSOMXView.ASCENSOMXViewViewModel.IsBusy = false;
                    COPAMXView.COPAMXViewViewModel.IsBusy = false;
                }

            }
            catch (HttpRequestException ex)
            {
                ASCENSOMXView.ASCENSOMXViewViewModel.IsBusy = false;
                COPAMXView.COPAMXViewViewModel.IsBusy = false;

            }
            catch (ApiException ex)
            {
                ASCENSOMXView.ASCENSOMXViewViewModel.IsBusy = false;
                COPAMXView.COPAMXViewViewModel.IsBusy = false;
            }
        }
        #endregion
        #endregion
    }
}
