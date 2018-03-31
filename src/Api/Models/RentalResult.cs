namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;

    public class RentalResult : IResultMessage
    {
        [JsonProperty("offerId")]
        public string Id { get; set; }
        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }
    }
}