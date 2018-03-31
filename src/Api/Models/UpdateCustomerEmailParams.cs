namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class UpdateCustomerEmailParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("newEmail")]
        public string NewEmail { get; set; }

        public UpdateCustomerEmailParams(string customerEmail, string newEmail)
        {
            this.CustomerEmail = customerEmail;
            this.NewEmail = newEmail;
        }

        public UpdateCustomerEmailParams(string publisherToken, string customerEmail, string newEmail)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.NewEmail = newEmail;
        }
    }
}