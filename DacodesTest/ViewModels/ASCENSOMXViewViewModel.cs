﻿using DacodesTest.Models.Games;
using DacodesTest.Views;
using MvvmHelpers;
using MvvmHelpers.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DacodesTest.ViewModels
{
    public class ASCENSOMXViewViewModel : BaseViewModel
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

        #region [ GroupList ]
        private ObservableCollection<GamesGroup> _gamesGroup;

        public ObservableCollection<GamesGroup> GamesGroup
        {
            get { return _gamesGroup; }
            set { SetProperty(ref _gamesGroup, value); }
        }
        #endregion

        //#region [RegionASCENSO]
        //private ObservableCollection<GameData> _gamesAscenso;

        //public ObservableCollection<GameData> GamesAscenso
        //{
        //    get { return _gamesAscenso; }
        //    set { SetProperty(ref _gamesAscenso, value); }
        //}
        //#endregion
        
        #endregion

        #region [ Constructor ]
        public ASCENSOMXViewViewModel()
        {
        }

        #endregion

        #region [ Metodos/Comandos ]

        #region [ Crear Grupo]
        public void CreateGroup(List<GameData> list)
        {
            var Groups = new List<GamesGroup>();

            var groupEnero = new GamesGroup(list.Where(a => a.Datetime.Month == 1).ToList())
            {
                Heading = "Enero"
            };

            var groupFebrero = new GamesGroup(list.Where(a => a.Datetime.Month == 2).ToList())
            {
                Heading = "Febrero",
            };

            var groupMarzo = new GamesGroup(list.Where(a => a.Datetime.Month == 3).ToList())
            {
                Heading = "Marzo",
            };

            var groupAbril = new GamesGroup(list.Where(a => a.Datetime.Month == 4).ToList())
            {
                Heading = "Abril",
            };

            var groupMayo = new GamesGroup(list.Where(a => a.Datetime.Month == 5).ToList())
            {
                Heading = "Mayo",
            };

            var groupJunio = new GamesGroup(list.Where(a => a.Datetime.Month == 6).ToList())
            {
                Heading = "Junio",
            };

            var groupJulio = new GamesGroup(list.Where(a => a.Datetime.Month == 7).ToList())
            {
                Heading = "Julio",
            };

            var groupAgosto = new GamesGroup(list.Where(a => a.Datetime.Month == 8).ToList())
            {
                Heading = "Agosto",
            };

            var groupSeptiembre = new GamesGroup(list.Where(a => a.Datetime.Month == 9).ToList())
            {
                Heading = "Septiembre",
            };

            var groupOctubre = new GamesGroup(list.Where(a => a.Datetime.Month == 10).ToList())
            {
                Heading = "Octubre",
            };

            var groupNoviembre = new GamesGroup(list.Where(a => a.Datetime.Month == 11).ToList())
            {
                Heading = "Noviembre",
            };

            var groupDiciembre = new GamesGroup(list.Where(a => a.Datetime.Month == 12).ToList())
            {
                Heading = "Diciembre",
            };

            Groups.Add(groupEnero);
            Groups.Add(groupFebrero);
            Groups.Add(groupMarzo);
            Groups.Add(groupAbril);
            Groups.Add(groupMayo);
            Groups.Add(groupJunio);
            Groups.Add(groupJulio);
            Groups.Add(groupAgosto);
            Groups.Add(groupSeptiembre);
            Groups.Add(groupOctubre);
            Groups.Add(groupNoviembre);
            Groups.Add(groupDiciembre);

            GamesGroup = new ObservableCollection<GamesGroup>(Groups.Where(a => a.Count > 0).ToList());
        }
        #endregion

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
