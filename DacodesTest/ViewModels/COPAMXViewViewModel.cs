using DacodesTest.Models.Games;
using DacodesTest.Views;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DacodesTest.ViewModels
{
    public class COPAMXViewViewModel : BaseViewModel
    {
        #region [ Constantes ]
        private ICommand _loadGames;
        #endregion

        #region [ Variables ]

        #endregion

        #region [ Propiedades ]

        #region [ IsRefreshing ]
        private bool _isrefreshing;

        public bool IsRefreshing
        {
            get { return _isrefreshing; }
            set { SetProperty(ref _isrefreshing, value); }
        }
        #endregion

        #region [RegionCOPAMX]
        private ObservableCollection<GameData> _gamesCopaMx;

        public ObservableCollection<GameData> GamesCopaMx 
        { 
            get { return _gamesCopaMx; }
            set { SetProperty(ref _gamesCopaMx, value); }
        }
        #endregion

        #endregion

        #region [ Constructor ]
        public COPAMXViewViewModel()
        {
        }
        #endregion

        #region [ Metodos/Comandos ]
        #region [ Lanzar PulltoRefresh ]

        public ICommand GetGamesCommand
        {
            get
            {
                return _loadGames ?? (_loadGames = new Command(async () => await ShowGames()));
            }
        }

        private async Task ShowGames()
        {
            HomeView.HomeViewViewModel.GetGames.Execute(null);
            IsRefreshing = false;
        }

        #endregion
        #endregion
    }
}
