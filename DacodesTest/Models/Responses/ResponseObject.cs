using Newtonsoft.Json;

namespace DacodesTest.Models.Responses
{
    public sealed class ResponseObject<obj>
    {
        [JsonProperty("data")]
        public obj Result { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
