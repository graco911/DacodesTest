using Newtonsoft.Json;
using System;

namespace DacodesTest.Models.Notifications
{
    public abstract class NotificationBase
    {
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
