using Newtonsoft.Json;

namespace DacodesTest.Models.Sponsors
{
    public abstract class SponsorBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("phone")]
        public string Phone { get; set; }
        [JsonProperty("address")]
        public string Address { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("facebook")]
        public string Facebook { get; set; }
        [JsonProperty("twitter")]
        public string Twitter { get; set; }
        [JsonProperty("instagram")]
        public string Instagram { get; set; }
    }
}
