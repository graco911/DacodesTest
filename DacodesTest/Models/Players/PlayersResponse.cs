using Newtonsoft.Json;

namespace DacodesTest.Models.Players
{
    public sealed class PlayersResponse
    {
        [JsonProperty("team")]
        public PlayersData Team { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
