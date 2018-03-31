namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class ListCustomerSubscriptionsParams: IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }

        public ListCustomerSubscriptionsParams(string publisherToken,
                                               string customerEmail,
                                               int offset,
                                               int limit)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.Offset = offset;
            this.Limit = limit;
        }

        public ListCustomerSubscriptionsParams(string customerEmail,
                                               int offset,
                                               int limit)
        {
            this.CustomerEmail = customerEmail;
            this.Offset = offset;
            this.Limit = limit;
        }
    }
}