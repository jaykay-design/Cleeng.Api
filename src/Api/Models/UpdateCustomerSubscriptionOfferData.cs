namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;

    public class UpdateCustomerSubscriptionOfferData
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        public UpdateCustomerSubscriptionOfferData(string status, DateTime expiresAt)
        {
            this.Status = status;
            this.ExpiresAt = expiresAt;
        }
    }
}