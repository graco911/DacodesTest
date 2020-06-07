using DacodesTest.Models.Statistics;
using MvvmHelpers;
using MvvmHelpers.Commands;
using Refit;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DacodesTest.ViewModels
{
    public class StatisticsViewViewModel : BaseViewModel
    {
        #region [ Constantes ]
        private ICommand _loadStatistics;
        public Command GetStatisticsCommand;
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

        #region [ Statistics ]
        private ObservableCollection<StatisticsData> _statistics;

        public ObservableCollection<StatisticsData> Statistics
        {
            get { return _statistics; }
            set { SetProperty(ref _statistics, value); }
        }
        #endregion

        #endregion

        #region [ Constructor ]
        public StatisticsViewViewModel()
        {
            GetStatisticsCommand = new Command(async () => await GetStatistics());

            GetStatisticsCommand.Execute(null);
        }

        #endregion

        #region [ Metodos/Comandos ]

        #region [ Lanzar PulltoRefresh ]

        public ICommand GetStatisticsRefreshCommand
        {
            get
            {
                return _loadStatistics ?? (_loadStatistics = new Command(async () => await GetStatistics()));
            }
        }

        #endregion

        #region [ GetStatistics ]
        private async Task GetStatistics()
        {
            try
            {
                IsBusy = true;

                var requestData = await App.apiService.VenadosAPI.StatisticsGet();

                if (requestData.Success)
                {
                    Statistics = new ObservableCollection<StatisticsData>(requestData.Result.Statistics);

                    IsBusy = false;
                    IsRefreshing = false;
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

        }
        #endregion

        #endregion
    }
}
