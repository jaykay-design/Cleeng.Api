namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GenerateCustomerTokenFromFacebookParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("facebookId")]
        public string FacebookId { get; set; }

        public GenerateCustomerTokenFromFacebookParams()
        {

        }

        public GenerateCustomerTokenFromFacebookParams(string publisherToken, string facebookId)
        {
            this.PublisherToken = publisherToken;
            this.FacebookId = facebookId;
        }

    }
}