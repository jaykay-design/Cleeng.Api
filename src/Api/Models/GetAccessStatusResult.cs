namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;

    public class GetAccessStatusResult : IResultMessage
    {
        [JsonProperty("accessGranted")]
        public bool AccessGranted { get; set; }
        [JsonProperty("grantType")]
        public string GrantType { get; set; }
        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }
        [JsonProperty("purchasedDirectly")]
        public bool PurchasedDirectly { get; set; }
    }
}