namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class RegisterCustomerParams
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("customerData")]
        public CustomerData CustomerData { get; set; }

        public RegisterCustomerParams(string publisherToken, CustomerData customerData)
        {
            this.PublisherToken = publisherToken;
            this.CustomerData = customerData;
        }
    }
}