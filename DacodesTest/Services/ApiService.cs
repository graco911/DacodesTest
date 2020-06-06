using DacodesTest.Interfaces;
using Refit;

namespace DacodesTest.Services
{
    public static class ApiService
    {
        private static string baseUrl = "https://venados.dacodes.mx/api";

        public static IVenados VenadosAPI() => RestService.For<IVenados>(baseUrl);
    }
}
