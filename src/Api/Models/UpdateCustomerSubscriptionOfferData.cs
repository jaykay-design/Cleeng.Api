namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;

    public class UpdateCustomerSubscriptionOfferData
    {
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }
        [JsonProperty("expiresAt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        public UpdateCustomerSubscriptionOfferData(string status, DateTime expiresAt)
        {
            this.Status = status;
            this.ExpiresAt = expiresAt;
        }
    }
}