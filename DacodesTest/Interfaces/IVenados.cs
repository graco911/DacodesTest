using DacodesTest.Models.Games;
using DacodesTest.Models.Notifications;
using DacodesTest.Models.Players;
using DacodesTest.Models.Responses;
using DacodesTest.Models.Sponsors;
using DacodesTest.Models.Statistics;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DacodesTest.Interfaces
{
    public interface IVenados
    {
        [Get("/statistics")]
        Task<ResponseObject<List<StatisticsData>>> StatisticsGet();

        [Get("/games")]
        Task<ResponseObject<List<GameData>>> GamesGet();

        [Get("/players")]
        Task<ResponseObject<PlayersData>> PlayersGet();

        [Get("/sponsors")]
        Task<ResponseObject<List<SponsorData>>> SponsorsGet();

        [Get("/notifications")]
        Task<ResponseObject<List<NotificationData>>> NotificationsGet();
    }
}
