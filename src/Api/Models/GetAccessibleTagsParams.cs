namespace Cleeng.Api.Models
{
    using Newtonsoft.Json;

    public class GetAccessibleTagsParams: IRequestMessage
    {
        [JsonProperty("publisherToken")]
        public string PublisherToken { get; set; }
        [JsonProperty("customerToken")]
        public string CustomerToken { get; set; }

        public GetAccessibleTagsParams()
        {

        }

        public GetAccessibleTagsParams(string publisherToken, string customerToken)
        {
            this.PublisherToken = publisherToken;
            this.CustomerToken = customerToken;
        }
    }
}