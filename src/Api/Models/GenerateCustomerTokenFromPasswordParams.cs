namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GenerateCustomerTokenFromPasswordParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        public GenerateCustomerTokenFromPasswordParams()
        {

        }

        public GenerateCustomerTokenFromPasswordParams(string publisherToken, string password, string customerEmail)
        {
            this.PublisherToken = publisherToken;
            this.Password = password;
            this.CustomerEmail = customerEmail;
        }
    }
}