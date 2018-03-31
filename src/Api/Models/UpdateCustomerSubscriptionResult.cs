namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UpdateCustomerSubscriptionResult
    {
        [JsonProperty("offerId")]
        public string OfferId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("expiresAt")]
        public string ExpiresAt { get; set; }
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }
    }
}