using Newtonsoft.Json;
using System.Collections.Generic;

namespace DacodesTest.Models.Games
{
    public sealed class GameResponse
    {
        [JsonProperty("games")]
        public List<GameData> Games { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
