using DacodesTest.Models.Players;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Refit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DacodesTest.ViewModels
{
    public class PlayersViewViewModel : BaseViewModel
    {
        #region [ Constantes ]
        private ICommand _loadPlayers;
        public Command GetPlayersCommand;
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

        #region [ GroupList ]
        private ObservableCollection<PlayersGroup> _playersGroup;

        public ObservableCollection<PlayersGroup> PlayersGroup
        {
            get { return _playersGroup; }
            set { SetProperty(ref _playersGroup, value); }
        }
        #endregion

        #endregion

        #region [ Constructor ]
        public PlayersViewViewModel()
        {
            GetPlayersCommand = new Command(async () => await GetPlayers());
            GetPlayersCommand.Execute(null);
        }
        #endregion

        #region [ Metodos/Comandos ]

        #region [ GetPlayers ]
        private async Task GetPlayers()
        {
            try
            {
                IsBusy = true;

                var requestData = await App.apiService.VenadosAPI.PlayersGet();

                if (requestData.Success)
                {
                    var groups = new List<PlayersGroup>();

                    var group1 = new PlayersGroup(requestData.Result.Team.Centers)
                    {
                        Heading = nameof(requestData.Result.Team.Centers)
                    };

                    var group2 = new PlayersGroup(requestData.Result.Team.Coaches)
                    {
                        Heading = nameof(requestData.Result.Team.Coaches)
                    };

                    var group3 = new PlayersGroup(requestData.Result.Team.Defenses)
                    {
                        Heading = nameof(requestData.Result.Team.Defenses)
                    };

                    var group4 = new PlayersGroup(requestData.Result.Team.Forwards)
                    {
                        Heading = nameof(requestData.Result.Team.Forwards)
                    };

                    var group5 = new PlayersGroup(requestData.Result.Team.Goalkeepers)
                    {
                        Heading = nameof(requestData.Result.Team.Goalkeepers)
                    };

                    groups.Add(group1);
                    groups.Add(group2);
                    groups.Add(group3);
                    groups.Add(group4);
                    groups.Add(group5);

                    PlayersGroup = new ObservableCollection<PlayersGroup>(groups);

                    IsRefreshing = false;
                    IsBusy = false;
                }

            }
            catch (HttpRequestException ex)
            {
                IsRefreshing = false;

                IsBusy = false;

            }
            catch (ApiException ex)
            {
                IsRefreshing = false;

                IsBusy = false;
            }
            catch (Exception ex)
            {

            }
        }
        #endregion

        #endregion
    }
}
