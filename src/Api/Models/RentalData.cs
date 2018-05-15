namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;

    public class RentalData
    {
        [JsonProperty("exiresAt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExiresAt { get; set; }

        public RentalData(DateTime expiresAt)
        {
            this.ExiresAt = expiresAt;
        }

        public RentalData()
        {

        }
    }
}