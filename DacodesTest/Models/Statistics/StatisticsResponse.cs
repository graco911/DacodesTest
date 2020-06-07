using Newtonsoft.Json;
using System.Collections.Generic;

namespace DacodesTest.Models.Statistics
{
    public sealed class StatisticsResponse
    {
        [JsonProperty("statistics")]
        public List<StatisticsData> Statistics { get; set; }
        [JsonProperty("code")]
        public int Code { get; set; }
    }
}
