namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System;

    public class CustomerSubscription: IResultMessage
    {
        [JsonProperty("offerId")]
        public string SubscriptionId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }
        [JsonProperty("nextPaymentPrice")]
        public double NextPaymentPrice { get; set; }
        [JsonProperty("nextPaymentCurrency")]
        public string NextPaymentCurrency { get; set; }
        [JsonProperty("paymentGateway")]
        public string PaymentGateway { get; set; }
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }
    }
}