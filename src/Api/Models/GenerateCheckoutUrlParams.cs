namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GenerateCheckoutUrlParams : IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }

        [JsonProperty("customerEmail")]
        public string CustomerEmail { get; set; }

        [JsonProperty("flowDescription")]
        public FlowDescription FlowDescription { get; set; }

        public GenerateCheckoutUrlParams(string publisherToken, string customerEmail, FlowDescription flowDescription)
        {
            this.PublisherToken = publisherToken;
            this.CustomerEmail = customerEmail;
            this.FlowDescription = flowDescription;
        }
    }
}