using DacodesTest.Interfaces;
using Refit;
using System.Net.Http;

namespace DacodesTest.Services
{
    public class ApiService
    {
        private string baseUrl = "https://venados.dacodes.mx/api";

        public IVenados VenadosAPI { get; set; }

        public ApiService()
        {
            var configuredHttpClient = new HttpClient();
            configuredHttpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            VenadosAPI = RestService.For<IVenados>(configuredHttpClient);
        }
    }
}
