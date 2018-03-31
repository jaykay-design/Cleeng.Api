namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class IsTrialAllowedParams
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }
        [JsonProperty("offerId")]
        public string OfferId { get; set; }

        public IsTrialAllowedParams(string publisherToken, string customerEmail, string offerId)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.OfferId = offerId;
        }

        public IsTrialAllowedParams(string customerEmail, string offerId)
        {
            this.CustomerEmail = customerEmail;
            this.OfferId = offerId;
        }
    }
}