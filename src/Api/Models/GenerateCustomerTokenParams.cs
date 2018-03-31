namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GenerateCustomerTokenParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        public GenerateCustomerTokenParams()
        {

        }

        public GenerateCustomerTokenParams(string publisherToken, string customerEmail)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
        }
    }
}