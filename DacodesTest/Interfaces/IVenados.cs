using Refit;
using System;
using System.Threading.Tasks;

namespace DacodesTest.Interfaces
{
    public interface IVenados
    {
        [Get("/statistics")]
        Task<Object> StatisticsGet();

        [Get("/games")]
        Task<Object> GamesGet();

        [Get("/players")]
        Task<Object> PlayersGet();

        [Get("/sponsors")]
        Task<Object> SponsorsGet();

        [Get("/notifications")]
        Task<Object> NotificationsGet();
    }
}
