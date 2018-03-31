namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UpdateCustomerSubscriptionParams:  IRequestMessage
    {

        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }
        [JsonProperty("offerId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("subscriptionData")]
        public UpdateCustomerSubscriptionOfferData SubscriptionData { get; set; }

        public UpdateCustomerSubscriptionParams(string publisherToken,
                                                string customerEmail,
                                                string subscriptionId,
                                                UpdateCustomerSubscriptionOfferData subscriptionData)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionData = subscriptionData;
        }

        public UpdateCustomerSubscriptionParams(string customerEmail,
                                                string subscriptionId,
                                                UpdateCustomerSubscriptionOfferData subscriptionData)
        {
            this.CustomerEmail = customerEmail;
            this.SubscriptionId = subscriptionId;
            this.SubscriptionData = subscriptionData;
        }
    }
}